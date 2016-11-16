
using Piz.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PizService.Models
{
   [DataContract]
   public class PizzaToppingDAO
   {
      [DataMember]
      public int ToppingId { get; set; }
      [DataMember]
      public int PizzaId { get; set; }
      [DataMember]
      public virtual ToppingDAO Topping { get; set; }
   }
}
