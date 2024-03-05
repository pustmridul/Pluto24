﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created {  get; set; }
        public DateTime Updated { get; set; }
    }
}
