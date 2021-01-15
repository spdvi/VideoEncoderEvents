using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsMosh
{
    public class MailService
    {
        public void SendMailOnVideoEncoded(object sender, EventArgs e)
        {
            Console.WriteLine("MailService: The video xxx has been" +
                " encoded and is ready for publishing");
        }
    }
}
