using System;
namespace Polymorph
{
    public interface INotification
    {
        void Send(Message message);
    }
}
