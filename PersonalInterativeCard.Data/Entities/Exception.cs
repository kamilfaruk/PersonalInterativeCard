﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInterativeCard.Data.Entities
{
    public class Exception : BaseEntity
    {
        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string HelpLink { get; set; }
        public string TargetSite { get; set; }
    }
}
