using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsMosh
{
    public class VideoEncoder
    {
        // Declare the event
        

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            Console.WriteLine("Video encoded correctly");

            // Trigger|Raise the event
            
        }
    }
}
