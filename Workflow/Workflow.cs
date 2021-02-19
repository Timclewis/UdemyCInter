using System;
using System.Collections.Generic;

namespace Workflow
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
            Console.WriteLine("Added activity");
        }

        public void Remove(IActivity activity)
        {
            _activities.Add(activity);
            Console.WriteLine("Removed activity");
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}
