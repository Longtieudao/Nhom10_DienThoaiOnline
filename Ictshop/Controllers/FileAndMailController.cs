using Ictshop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Controllers
{
    public class FileAndMailController : Controller
    {
        // GET: FileAndMail
        public ActionResult SendMail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMail(Mail Models)
        {
            var mail = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("2124802010091@student.tdmu.edu.vn", "0336605307"),
                EnableSsl = true
            };
            var message = new MailMessage();
            message.From = new MailAddress(Models.From);
            message.ReplyToList.Add(Models.From);
            message.To.Add(new MailAddress(Models.To));
            message.Subject = Models.Subject;
            message.Body = Models.Notes;


            var f = Request.Files["Attachments"];
            var path = Path.Combine(Server.MapPath("~/Images"), f.FileName);
            if (!System.IO.File.Exists(path))
            {
                f.SaveAs(path);
            }

            Attachment data = new Attachment(Server.MapPath("~/Images/" + f.FileName), MediaTypeNames.Application.Octet);
            message.Attachments.Add(data);

            mail.Send(message);
            return View("SendMail");
        }
    
}
}