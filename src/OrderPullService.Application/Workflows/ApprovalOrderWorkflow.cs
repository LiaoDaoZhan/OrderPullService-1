using Elsa;
using Elsa.Activities;
using Elsa.Activities.Console.Activities;
using Elsa.Activities.ControlFlow.Activities;
using Elsa.Activities.Email.Activities;
using Elsa.Activities.Http.Activities;
using Elsa.Activities.Timers.Activities;
using Elsa.Activities.Workflows.Activities;
using Elsa.Expressions;
using Elsa.Scripting.JavaScript;
using Elsa.Services;
using Elsa.Services.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace OrderPullService.Workflows
{
    /// <summary>
    /// 审批订单的工作流程
    /// </summary>
    public class ApprovalOrderWorkflow : IWorkflow
    {
        public void Build(IWorkflowBuilder builder)
        {
            {
                builder
                    .StartWith<WriteLine>(x => x.TextExpression = new LiteralExpression("欢迎进行订单审批工作流!"))
                    //.StartWith<ReceiveHttpRequest>(
                    //    x =>
                    //    {
                    //        x.Method = HttpMethod.Post.Method;
                    //        x.Path = new Uri("/documents", UriKind.Relative);
                    //        x.ReadContent = true;
                    //    }
                    //).WithName("WaitForDocument")
                    .Then<SetVariable>(
                        x =>
                        {
                            x.VariableName = "Document";
                            x.ValueExpression = new JavaScriptExpression<object>("WaitForDocument.Content");
                        }
                    )
                    .Then<SendEmail>(
                        x =>
                        {
                            x.From = new LiteralExpression("approval@acme.com");
                            x.To = new JavaScriptExpression<string>("Document.Author.Email");
                            x.Subject =
                                new JavaScriptExpression<string>("`Document received from ${Document.Author.Name}`");
                            x.Body = new JavaScriptExpression<string>(
                                "`Document from ${Document.Author.Name} received for review. " +
                                "<a href=\"${signalUrl('Approve')}\">Approve</a> or <a href=\"${signalUrl('Reject')}\">Reject</a>`"
                            );
                        }
                    )
                    .Then<WriteHttpResponse>(
                        x =>
                        {
                            x.Content = new LiteralExpression(
                                "<h1>Request for Approval Sent</h1><p>Your document has been received and will be reviewed shortly.</p>"
                            );
                            x.ContentType = "text/html";
                            x.StatusCode = HttpStatusCode.OK;
                            x.ResponseHeaders = new LiteralExpression("X-Powered-By=Elsa Workflows");
                        }
                    )
                    .Then<SetVariable>(
                        x =>
                        {
                            x.VariableName = "Approved";
                            x.ValueExpression = new LiteralExpression<bool>("false");
                        }
                    )
                    // 创建新的分支
                    .Then<Fork>(
                        x => { x.Branches = new[] { "Approve", "Reject", "Remind" }; },
                        fork =>
                        {
                            // 批准
                            fork
                                .When("Approve")
                                .Then<Signaled>(x => x.Signal = new LiteralExpression("Approve"))
                                .Then("Join");

                            // 拒绝
                            fork
                                .When("Reject")
                                .Then<Signaled>(x => x.Signal = new LiteralExpression("Reject"))
                                .Then("Join");

                            // 提醒
                            fork
                                .When("Remind")
                                .Then<TimerEvent>(
                                    x => x.TimeoutExpression = new LiteralExpression<TimeSpan>("00:00:10")
                                ).WithName("RemindTimer")
                                .Then<IfElse>(
                                    x => x.ConditionExpression = new JavaScriptExpression<bool>("!!Approved"),
                                    ifElse =>
                                    {
                                        ifElse
                                            .When(OutcomeNames.False)
                                            .Then<SendEmail>(
                                                x =>
                                                {
                                                    x.From = new LiteralExpression("reminder@acme.com");
                                                    x.To = new LiteralExpression("approval@acme.com");
                                                    x.Subject =
                                                        new JavaScriptExpression<string>(
                                                            "`${Document.Author.Name} is awaiting for your review!`"
                                                        );
                                                    x.Body = new JavaScriptExpression<string>(
                                                        "`Don't forget to review document ${Document.Id}.<br/>" +
                                                        "<a href=\"${signalUrl('Approve')}\">Approve</a> or <a href=\"${signalUrl('Reject')}\">Reject</a>`"
                                                    );
                                                }
                                            )
                                            .Then("RemindTimer");
                                    }
                                );
                        }
                    )

                    .Then<Join>(x => x.Mode = Join.JoinMode.WaitAny).WithName("Join")
                    .Then<SetVariable>(
                        x =>
                        {
                            x.VariableName = "Approved";
                            x.ValueExpression = new JavaScriptExpression<object>("input('Signal') === 'Approve'");
                        }
                    )
                    .Then<IfElse>(
                        x => x.ConditionExpression = new JavaScriptExpression<bool>("!!Approved"),
                        ifElse =>
                        {
                            ifElse
                                .When(OutcomeNames.True)
                                .Then<SendEmail>(
                                    x =>
                                    {
                                        x.From = new LiteralExpression("approval@acme.com");
                                        x.To = new JavaScriptExpression<string>("Document.Author.Email");
                                        x.Subject =
                                            new JavaScriptExpression<string>("`Document ${Document.Id} approved!`");
                                        x.Body = new JavaScriptExpression<string>(
                                            "`Great job ${Document.Author.Name}, that document is perfect! Keep it up.`"
                                        );
                                    }
                                );

                            ifElse
                                .When(OutcomeNames.False)
                                .Then<SendEmail>(
                                    x =>
                                    {
                                        x.From = new LiteralExpression("approval@acme.com");
                                        x.To = new JavaScriptExpression<string>("Document.Author.Email");
                                        x.Subject =
                                            new JavaScriptExpression<string>("`Document ${Document.Id} rejected`");
                                        x.Body = new JavaScriptExpression<string>(
                                            "`Sorry ${Document.Author.Name}, that document isn't good enough. Please try again.`"
                                        );
                                    }
                                );
                        }
                    );
            }
        }
    }
}
