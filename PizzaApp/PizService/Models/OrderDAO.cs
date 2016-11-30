﻿using Piz.DataAccess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PizService.Models
{
   [DataContract]
   public class OrderDAO
   {
      
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public string Name { get; set; }
      [DataMember]
      public decimal Value { get; set; }
      [DataMember]
      public int StoreId { get; set; }
      [DataMember]
      public int CustomerId { get; set; }
      [DataMember]
      public virtual CustomerDAO Customer { get; set; }
      [DataMember]
      public virtual StoreDAO Store { get; set; }
      
   }
}
