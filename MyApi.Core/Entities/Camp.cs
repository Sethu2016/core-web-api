using System;
using System.Collections.Generic;
using System.Text;

namespace MyApi.Core.Entities
{
    public class Camp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Moniker { get; set; }
        public Location Location { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int Length { get; set; } = 1;
        public ICollection<Talk> Talks { get; set; }
    }
}
