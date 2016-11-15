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
   public class PizzaCheeseDAO
   {
      [DataMember]
      public virtual Cheese Cheese { get; set; }
      [DataMember]
      public virtual Pizza Pizza { get; set; }
   }
}
