using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HalWebDictionary2.Models;

namespace HalWebDictionary2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public HalItemList Get()
        {
            var items = Enumerable.Range(0, 10).Select(item =>
                new HalItem(item.ToString(CultureInfo.InvariantCulture),
                    "Name" + item, "Title" + item,
                    new Dictionary<string, object>
                    {
                        {"Property1", item},
                        {"Property2", item.ToString()}
                    })).ToList();
            return new HalItemList(items);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
