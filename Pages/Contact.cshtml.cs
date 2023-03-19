using MailKit.Security;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Build.Framework;
using MimeKit;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Bookclub.Pages
{
    public class ContactModel : PageModel
    {
        
        [BindProperty]
        [System.ComponentModel.DataAnnotations.Required]
        public string subject { get; set; }

        [BindProperty]
        [EmailAddress]
        [System.ComponentModel.DataAnnotations.Required]
        public string email{ get; set; }

        [BindProperty]
        [System.ComponentModel.DataAnnotations.Required]
        public string body { get; set; }

       
        public bool checker { get; set; }


        public void OnGet()
        {
        }

        public void OnPost()
        {
            checker = false;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            System.Net.NetworkCredential credential = 
                new System.Net.NetworkCredential("between2linesteam@gmail.com", "atscwnkgpsbuqmeq");
            client.Credentials = credential;


            MailAddress from = new MailAddress(email,subject);
            MailAddress to = new MailAddress("between2linesteam@gmail.com", subject);

            var message = new MailMessage(from, to);
            message.Subject= subject;
            message.Body= body;

            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml=true; 
            client.EnableSsl= true;
            client.UseDefaultCredentials= false;
            
            client.Send(message);
            checker = true;
            
            client.Dispose();
           
        }
    }
}
