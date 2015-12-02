using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daterbase2._0.Models
{
    public class Message
    {
        //TODO constraints on... like subject length... protect recipient name? senderID?
        public int MessageID { get; set; }
        public string Subject { get; set; }
        [DisplayName("")]
        public string Contents { get; set; }
        [DisplayName("Send To")]
        public string RecipientName { get; set; }

        [ForeignKey("Sender")]
        public string SenderID { get; set; }

        public virtual ApplicationUser Sender { get; set; }
    }
}
