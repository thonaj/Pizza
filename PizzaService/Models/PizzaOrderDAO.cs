using Pizza.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Models
{
   [DataContract]
   public class PizzaOrderDAO
   {
      [DataMember]
      public virtual Order Order { get; set; }
      [DataMember]
      public virtual Pizza.DAL.Pizza Pizza { get; set; }
   }
}
