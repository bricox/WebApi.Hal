using System.Collections.Generic;
using WebApi.Hal;

namespace HalWebDictionary2.Models
{
    public class HalItemList : RepresentationList<HalItem>
    {
        public int Count { get; set; }

        public HalItemList(IList<HalItem> res) : base(res)
        {
            Count = res.Count;
        }

        protected override void CreateListHypermedia()
        {
            Links.Add(new Link("self", "www.tn.gov"));
        }
    }
}