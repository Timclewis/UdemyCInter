using System;

namespace Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var Aworkflow = new Workflow();
            Aworkflow.Add(new VideoUpload());

            var engine = new WorkflowEngine();
            engine.Run(Aworkflow);

        }
    }
}
