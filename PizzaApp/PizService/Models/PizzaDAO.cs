
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
      public int Id { get; set; }
      [DataMember]
      public string Name { get; set; }
      [DataMember]
      public int CrustId { get; set; }
      [DataMember]
      public int SauceId { get; set; }
      [DataMember]
      public int SizeId { get; set; }
      [DataMember]
      public Nullable<int> OrderId { get; set; }
      [DataMember]
      public virtual CrustDAO Crust { get; set; }
      [DataMember]
      public virtual OrderDAO Order { get; set; }
      [DataMember]
      public virtual SauceDAO Sauce { get; set; }
      [DataMember]
      public virtual SizeDAO Size { get; set; }
   }
}
