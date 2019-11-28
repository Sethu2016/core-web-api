using System;
using System.Collections.Generic;
using System.Text;

namespace MyApi.Core.Entities
{
    public class Talk
    {
        public int Id { get; set; }
        public Camp Camp { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public int Level { get; set; }
        public Speaker Speaker { get; set; }
    }
}
