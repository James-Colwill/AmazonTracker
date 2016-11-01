using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //driver.Navigate().GoToUrl("https://www.amazon.com/Amazon-Echo-Bluetooth-Speaker-with-WiFi-Alexa/dp/B00X4WHP5E/ref=sr_1_1?ie=UTF8&qid=1477938972&sr=8-1&keywords=echo");
        //IWebElement temp = driver.FindElement(By.Id("priceblock_ourprice"));
        //string price = temp.Text;

        //SmtpClient client;
        //client = new SmtpClient("smtp.trashmail.com");
        //client.EnableSsl = true;
        //    //client.UseDefaultCredentials = false;
        //    //client.Credentials = new NetworkCredential("colwill.james", "WildLlama$");
        //    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
        //message.To.Add("4404799057@vtext.com");
        //    message.Subject = "Amazon Echo Price";
        //    message.From = new System.Net.Mail.MailAddress("uxoyeodh@trashmail.com");
        //    message.Body = price;
            
        //    client.Send(message);
    }
}
