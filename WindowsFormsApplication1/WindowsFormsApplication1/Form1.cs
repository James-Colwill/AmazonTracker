using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string initialPrice;
        private static IWebDriver driver = new ChromeDriver();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Item product = GetAmazonPrice();
            initialPrice = product.Price;
            SendMessage(product);
            
        }

        private Item GetAmazonPrice()
        {
            driver.Navigate().GoToUrl(@txtAmazonURL.Text);    
            IWebElement price = driver.FindElement(By.Id("priceblock_ourprice"));
            IWebElement title = driver.FindElement(By.Id("productTitle"));
            IWebElement availability = driver.FindElement(By.Id("availability"));
            

            Item product = new Item() {
                Price = price.Text,
                Title = title.Text,
                Availability = availability.Text,
        };

            

            return product;

            
        }

        private void SendMessage(Item item)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("username", "password");
            MailMessage message = new MailMessage();
            message.To.Add(txtSendAddress.Text); 
            message.Subject = item.Title;
            message.From = new MailAddress("email");
            message.Body = string.Format("{0} AT {1}  {2}", item.Price, DateTime.Now.ToShortTimeString(), item.Availability);
            
            client.Send(message);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Item product = GetAmazonPrice();
            string checkPrice = product.Price;

            if(checkPrice != initialPrice)
            {
                SendMessage(product);
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSendAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
