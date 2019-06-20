using System.Collections.Generic;

namespace CSharpIntermediate
{
    public interface IWorkflow
    {
        void Add(IWorkflowStep step);
        void Remove(IWorkflowStep step);
        IEnumerable<IWorkflowStep> GetWorkflowSteps();
    }
}