using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PizService.Models
{
   [DataContract]
    public class SizeDAO
   {
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public string Name { get; set; }
      [DataMember]
      public decimal Value { get; set; }
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      //public SizeDAO()
      //{
      //   this.Pizzas = new HashSet<PizzaDAO>();
      //}
      [DataMember]
      public bool Active { get; set; }
      //[DataMember]
      //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      //public virtual ICollection<PizzaDAO> Pizzas { get; set; }
   }
}
