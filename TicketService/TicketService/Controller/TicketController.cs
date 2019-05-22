using Grapevine.Interfaces.Server;
using Grapevine.Server;
using Grapevine.Server.Attributes;
using Grapevine.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketService
{
    [RestResource]
    class TicketController
    {

        #region POST

        [RestRoute(HttpMethod = HttpMethod.POST, PathInfo = "/api/ticket/add")]
        public IHttpContext AddContacto(IHttpContext context)
        {

            string json = JsonConvert.SerializeObject("", Formatting.Indented);
            context.Response.AppendHeader("Content-Type", "application/json");
            context.Response.SendResponse(json);
            return context;
        }

        #endregion
    }
}
