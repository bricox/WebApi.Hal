using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using WebApi.Hal;

namespace HalWebDictionary2.Models
{
    public class HalItem : Representation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public IDictionary<string, object> Properties { get; set; }

        public HalItem(string id, string name, string title, IDictionary<string, object> properties)
        {
            Id = id;
            Name = name;
            Title = title;
            Properties = properties;
        }

        protected override void CreateHypermedia()
        {
            Href = "www.tn.gov";
            Rel = "self";
        }
    }
}