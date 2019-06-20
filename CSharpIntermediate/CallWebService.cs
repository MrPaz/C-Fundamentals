using System;

namespace CSharpIntermediate
{
    public class CallWebService : IWorkflowStep
    {
        public void Execute()
        {
            Console.WriteLine("Calling Web Service . . .");
        }
    }
}
