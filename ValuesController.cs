using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        static List<string> data = initList();
        private static List<string> initList()
        {
            var ret = new List<string>();
            ret.Add("Value1");
            ret.Add("Value2");
            return ret;
        }
        public IEnumerable<string> Get()
        {
            return data;
        }

        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            if(data.Count>id)
            {
                return Request.CreateResponse<string>(HttpStatusCode.OK, data[id]);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error not found");
            }
                
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody] string value)
        {
            data.Add(value);
            var msg = Request.CreateResponse(HttpStatusCode.Created);
            msg.Headers.Location = new Uri(Request.RequestUri+ (data.Count - 1).ToString());
            return msg;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
                data[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
                data.RemoveAt(id);
        }
    }
}
