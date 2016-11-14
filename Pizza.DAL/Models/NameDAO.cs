﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.DAL.Models
{
   class NameDAO
   {
      public string First { get; set; }
      public string Last { get; set; }

      public override string ToString()
      {
         return string.Format("{0} {1}", First, Last);
      }
   }
}
