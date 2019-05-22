using Mongo.CRUD;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DMModel = TicketService.MTicket;

namespace TicketService
{
    class MainCore
    {
        #region CREATE

        public void Create(DMModel data)
        {
            IMongoCRUD<DMModel> db = new MongoCRUD<DMModel>("mongodb://51.83.73.69:27017", "TicketService");
            db.Create(data);
        }

        #endregion

        #region READ
        public List<DMModel> ReadAll()
        {
            IMongoCRUD<MTicket> db = new MongoCRUD<MTicket>("mongodb://51.83.73.69:27017", "TicketService");

            BsonDocument filter = new BsonDocument();
            filter.Add("_id", new BsonDocument()
                    .Add("$exists", new BsonBoolean(true))
            );

            var data = db.Search(filter).Documents.ToList();

            return data;

        }
        // FALTA ES BUSCAR POR CAMPO? ESTA EN QUERY       

        public DMModel ReadId(string id)
        {
            IMongoCRUD<MTicket> db = new MongoCRUD<MTicket>("mongodb://51.83.73.69:27017", "TicketService");
            
            return db.Get(ObjectId.Parse(id));

        }

        //public List<DMModel> ReadValue(string fieldName, string fieldValue)
        //{


        //}
        #endregion

        #region UPDATE
        public void Update(string id, MTicket data)
        {
            IMongoCRUD<DMModel> db = new MongoCRUD<DMModel>("mongodb://51.83.73.69:27017", "TicketService");
            DMModel document = new DMModel();

            document = db.Get(ObjectId.Parse(id));
            document = data;

            db.Update(data);

            //document.SomeProperty = "Something Modificado";


            //document.urls.Add("ur3333");
            //client.Update(document);


        }

        #endregion
    }
}