using Elsa.Attributes;
using Elsa.Extensions;
using Elsa.Results;
using Elsa.Services;
using Elsa.Services.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YamlDotNet.Core;

namespace OrderPullService.Workflows
{
    [ActivityDefinition(
        Category = "Approval Order",
        DisplayName = "接受提交审批订单的消息",
        Description = "通过ReceiveApprovalOrderMessage 接受审批消息"
    )]
    public class ReceiveApprovalOrderMessage : Activity
    {
        public static Type GetMessageType(JObject state)
        {
            var typeName = state.GetState<string>(nameof(MessageType));
            return string.IsNullOrWhiteSpace(typeName) ? null : System.Type.GetType(typeName);
        }

        [ActivityProperty(Hint = "The assembly-qualified type name of the message to receive.")]
        public Type MessageType
        {
            get => GetMessageType(State);
            set => SetState(value.AssemblyQualifiedName);
        }

        protected override bool OnCanExecute(WorkflowExecutionContext context)
        {
            // 获取输入变量
            var messageTypeName = context.Workflow.Input.GetVariable("Message");
            var messageInputType = System.Type.GetType(messageTypeName.ToString());
            var messageType = MessageType;

            return messageInputType != null && messageType != null && messageInputType == messageType;
        }

        protected override ActivityExecutionResult OnExecute(WorkflowExecutionContext context)
        {
            return Halt(true);
        }

        protected override Task<ActivityExecutionResult> OnResumeAsync(WorkflowExecutionContext context,
            CancellationToken cancellationToken)
        {
            // 获取消息输入
            var message = context.Workflow.Input.GetVariable("");
            context.SetLastResult(message);

            return Task.FromResult(Done());
        }
    }
}
