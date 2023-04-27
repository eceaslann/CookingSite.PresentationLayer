using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingSite.EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string ContactAddress { get; set; }
        public string ContactMail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMessage { get; set; }
    }
}
