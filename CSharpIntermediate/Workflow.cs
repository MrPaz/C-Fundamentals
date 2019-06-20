using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Workflow : IWorkflow
    {
        private readonly List<IWorkflowStep> _workflowSteps;

        public Workflow()
        {
            _workflowSteps = new List<IWorkflowStep>();
        }

        public void Add(IWorkflowStep step)
        {
            _workflowSteps.Add(step);
        }

        public void Remove(IWorkflowStep step)
        {
            _workflowSteps.Remove(step);
        }

        public IEnumerable<IWorkflowStep> GetWorkflowSteps()
        {
            return _workflowSteps;
        }
    }
}