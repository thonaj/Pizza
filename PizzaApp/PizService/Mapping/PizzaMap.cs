using PizService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Piz.DataAccess;

namespace PizService.Mapping
{
   public static class PizzaMap
   {
      public static Pizza MapToPizza(PizzaDAO b)
      {
         var a = new Pizza();
         a.Crust = CrustMap.MapToCrust(b.Crust);
         a.Sauce = SauceMap.MapToSauce(b.Sauce);
         a.Size = SizeMap.MapToSize(b.Size);
         a.CrustId = b.CrustId;
         a.Name = b.Name;
         a.Order = OrderMap.MapToOrder(b.Order);
         a.OrderId = b.OrderId;
         a.SauceId = b.SauceId;
         a.SizeId = b.SizeId;
         a.Id = b.Id;
         
         return a;
      }

      public static PizzaDAO MapToPizzaDAO(Pizza b)
      {
         var a = new PizzaDAO();
         a.Crust = CrustMap.MapToCrustDAO(b.Crust);
         a.Sauce = SauceMap.MapToSauceDAO(b.Sauce);
         a.Size = SizeMap.MapToSizeDAO(b.Size);
         a.CrustId = b.CrustId;
         a.Name = b.Name;
         a.Order = OrderMap.MapToOrderDAO(b.Order);
         a.OrderId = b.OrderId;
         a.SauceId = b.SauceId;
         a.SizeId = b.SizeId;
         a.Id = b.Id;
         return a;
      }
   }
}