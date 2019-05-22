using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketService
{
    class MTicket
    {
        public string _id { get; set; }
        public DateTime fecha { get; set; }
        public bool visible { get; set; }
        public string employeeServiceID { get; set; }
        public string documentServiceID { get; set; }
        public string mensaje { get; set; }
        public string serviceID { get; set; }
        public string tipoServicio { get; set; }
    }
}
