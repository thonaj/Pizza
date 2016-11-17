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
      public int Id { get; set; }
      [DataMember]
      public int CheeseId { get; set; }
      [DataMember]
      public int PizzaId { get; set; }
      [DataMember]
      public virtual CheeseDAO Cheese { get; set; }
      [DataMember]
      public virtual PizzaDAO Pizza { get; set; }
   }
}
