﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNba.ApiConsumer.Models
{
    public class Activeplayers
    {
        public string lastUpdatedOn { get; set; }
        public IList<Playerentry> playerentry { get; set; }
    }
}