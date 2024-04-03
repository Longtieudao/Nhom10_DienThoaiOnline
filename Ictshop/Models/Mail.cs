using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Ictshop.Models
{
    public class Mail
    {
        [DisplayName("Người gửi")]
        public string From { get; set; }
        [DisplayName("Người nhận")]
        public string To { get; set; }
        [DisplayName("Tiêu đề")]
        public string Subject { get; set; }

        [DisplayName("Nội dung")]
        public string Notes { get; set; }
        [DisplayName("File đính kèm")]
        public String Attachment { get; set; }



    }
}