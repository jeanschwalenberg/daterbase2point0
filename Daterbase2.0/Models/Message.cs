using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daterbase2._0.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string Subject { get; set; }
        public string Contents { get; set; }
        public string RecipientName { get; set; }

        [ForeignKey("Sender")]
        public string SenderID { get; set; }

        public virtual ApplicationUser Sender { get; set; }
    }
}
