using Elsa;
using Elsa.Attributes;
using Elsa.Expressions;
using Elsa.Results;
using Elsa.Services;
using Elsa.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderPullService.Workflows
{
    /// <summary>
    /// 客服审单
    /// </summary>
    [ActivityDefinition(
        Category = "Console",
        Description = "客服审单",
        Icon = "fas fa-terminal",
        RuntimeDescription = "x => !!x.state.textExpression ? `Write <strong>${ x.state.textExpression.expression }</strong> to standard out.` : x.definition.description",
        Outcomes = new[] { OutcomeNames.Done }
    )]
    public class CustomerServiceApprovalActivity: Activity
    {

        [ActivityProperty(Hint = "The text to write.")]
        public WorkflowExpression<CustomerServiceExpression> Expression
        {
            get => GetState(() => LiteralEvaluator.Expression<CustomerServiceExpression>(null));
            set => SetState(value);
        }

        protected override async Task<ActivityExecutionResult> OnExecuteAsync(WorkflowExecutionContext context, CancellationToken cancellationToken)
        {
            //return base.OnExecuteAsync(context, cancellationToken);
            var text = await context.EvaluateAsync(Expression, cancellationToken);
            
            return Outcome(OutcomeNames.Done);
        }
    }
}
