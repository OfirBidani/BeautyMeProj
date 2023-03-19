using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    public class ClientController : ApiController
    {
        // GET: api/Client
        [HttpGet]
        [Route("api/client")]
        public HttpResponseMessage Get()
        {
            igroup193_test1DBC db = new igroup193_test1DBC();
            List<ClientDTO> c = db.Client.Select(x => new ClientDTO
            {
                Email= x.Email,
                ID_number = x.ID_number,
                First_name = x.First_name,
                Last_name = x.Last_name,
                phone = x.phone,
                Address=x.Address,
                password=x.password
            }).ToList();
            if(c!=null)
            return Request.CreateResponse(HttpStatusCode.OK,c);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        // GET: api/Client/5
        [HttpGet]
        [Route("api/client/{id/{pass}")]
        public HttpResponseMessage Get(string id,string pass)
        {
            igroup193_test1DBC db = new igroup193_test1DBC();
            ClientDTO c1 = db.Client.Where(x => x.ID_number == id&&x.password==pass).Select(a => new ClientDTO
            {
                password=a.password,
                ID_number = a.ID_number,
                Last_name = a.Last_name,
                First_name = a.First_name
            }).FirstOrDefault();
            if(c1!=null)
            return Request.CreateResponse(HttpStatusCode.OK,c1);
            else
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        // POST: api/Client
        [HttpPost]
        [Route("api/client/{id}")]
        public HttpResponseMessage Post([FromBody]string pass,string id)
        {
            ClientDTO clientDTO= new ClientDTO();
            igroup193_test1DBC db=new igroup193_test1DBC();
            List<ClientDTO> clients = db.Client.Select(x => new ClientDTO
            {
                Email= x.Email,
                ID_number = x.ID_number,
                First_name = x.First_name,
                Last_name = x.Last_name,
                password=x.password
                
            }).ToList();
            foreach (ClientDTO c in clients)
            {
                if (c.ID_number==id)
                {
                    if (c.password == pass)
                        clientDTO = c;
                }
            }
            if (clientDTO!=null)
                return Request.CreateResponse(HttpStatusCode.OK, clientDTO);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound,"not found");
        }

        // PUT: api/Client/5
        [HttpPut]
        [Route("api/client/{id}")]
        public HttpResponseMessage Put(int id, [FromBody]Client value)
        {
            igroup193_test1DBC db = new igroup193_test1DBC();
            Client c = new Client();
            c = value;
            if (c!=null)
            {
                db.Client.Add(c);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "new client added to the dataBase");
            }
            else
                return Request.CreateResponse(HttpStatusCode.NoContent);



        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
        }
    }
}
