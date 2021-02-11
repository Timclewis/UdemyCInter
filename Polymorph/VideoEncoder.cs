using System;
using System.Collections.Generic;

namespace Polymorph
{
    public class VideoEncoder
    {
        private readonly IList<INotification> _notification;

        public VideoEncoder()
        {
            _notification = new List<INotification>();
        }       

        public void Encode(Video video)
        {
            // video encoding logic
            foreach (var channel in _notification)
                channel.Send(new Message());
        }

        public void RegisterNotification(INotification channel)
        {
            _notification.Add(channel);
        }
    }
}
