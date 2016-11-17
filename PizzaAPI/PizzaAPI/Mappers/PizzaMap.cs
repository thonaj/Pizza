using PizzaAPI.Models;
using PizzaAPI.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAPI.Mappers
{
   public class PizzaMap
   {
      public static PizzaDTO MapToPizzaDTO(PizzaDAO b)
      {
         var a = new PizzaDTO();
         a.Crust = CrustMap.MapToCrustDTO(b.Crust);
         a.CrustId = b.CrustId;
         a.Name = b.Name;
         a.Order = OrderMap.MapToOrderDTO(b.Order);
         a.OrderId = b.OrderId;
         a.Sauce = SauceMap.MapToSauceDTO(b.Sauce);
         a.SauceId = b.SauceId;
         a.Size = SizeMap.MapToSizeDTO(b.Size);
         a.SizeId = b.SizeId;
         
         return a;
      }

      public static PizzaDAO MapToPizzaDAO(PizzaDTO b)
      {
         var a = new PizzaDAO();
         a.Crust = CrustMap.MapToCrustDAO(b.Crust);
         a.CrustId = b.CrustId;
         a.Name = b.Name;
         a.Order = OrderMap.MapToOrderDAO(b.Order);
         a.OrderId = b.OrderId;
         a.Sauce = SauceMap.MapToSauceDAO(b.Sauce);
         a.SauceId = b.SauceId;
         a.Size = SizeMap.MapToSizeDAO(b.Size);
         a.SizeId = b.SizeId;

         return a;
      }
   }
}