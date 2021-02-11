using System;
namespace Polymorph
{
    public class SMS : INotification
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending a SMS");
        }
    }
}
