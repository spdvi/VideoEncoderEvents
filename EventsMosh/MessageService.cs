using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsMosh
{
    public class MessageService
    {
        public void SendMessageOnVideoEncoded(object sender, EventArgs e)
        {
            Console.WriteLine($"MessageService: The video xxx has been" +
                " encoded and is ready for publishing");
        }
    }
}
