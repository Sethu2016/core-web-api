﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyApi.Core.Models
{
    public class CampResource
    {

        public string Name { get; set; }
        public string Moniker { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int Length { get; set; } = 1;
    }
}
