using System;

namespace CSharpIntermediate
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (IWorkflowStep step in workflow.GetWorkflowSteps())
            {
                step.Execute();
            }

            Console.WriteLine("All workflow tasks completed");
        }
    }
}
