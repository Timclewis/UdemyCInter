using System;
using System.Collections.Generic;

namespace Workflow
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                try
                {
                    activity.Execute();
                }

                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                }
            }

        }
    }
}
