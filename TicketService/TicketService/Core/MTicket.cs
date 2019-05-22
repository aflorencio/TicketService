using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketService
{
    [BsonIgnoreExtraElements]
    class MTicket
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonIgnoreIfNull]
        public DateTime fecha { get; set; }
        [BsonIgnoreIfNull]
        public bool visible { get; set; }
        [BsonIgnoreIfNull]
        public ObjectId employeeServiceID { get; set; }
        [BsonIgnoreIfNull]
        public ObjectId documentServiceID { get; set; }
        [BsonIgnoreIfNull]
        public string mensaje { get; set; }
        [BsonIgnoreIfNull]
        public ObjectId serviceID { get; set; }
        [BsonIgnoreIfNull]
        public string tipoServicio { get; set; }
    }
}
