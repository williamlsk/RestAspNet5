using RestWithASPNETUdemy.HyperMedia.Abstract;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.HyperMedia.Filters
{
    public class HypermediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();


    }
}
