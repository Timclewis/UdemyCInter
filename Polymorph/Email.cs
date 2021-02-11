using System;
namespace Polymorph
{
    public class Email : INotification
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending email");
        }
    }
}
