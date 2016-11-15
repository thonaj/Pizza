
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
   public class PizzaDAO
   {
      [DataMember]
      public virtual Crust Crust { get; set; }
      [DataMember]
      public virtual Sauce Sauce { get; set; }
      [DataMember]
      public virtual Size Size { get; set; }
      [DataMember]
      public virtual ICollection<PizzaCheese> PizzaCheese { get; set; }
      [DataMember]
      public virtual ICollection<PizzaTopping> PizzaToppings { get; set; }
   }
}
