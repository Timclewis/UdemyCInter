using System;

namespace Polymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotification(new Email());
            encoder.RegisterNotification(new SMS());
            encoder.Encode(new Video());
        }
    }
}
