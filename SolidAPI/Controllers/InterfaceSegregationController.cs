using Microsoft.AspNetCore.Mvc;
using SolidAPI.Resolvers;

namespace SolidAPI.Controllers;

[ApiController]
public class InterfaceSegregationController
{
   [HttpGet(Name = "InterfaceSegregation")]
   public void InterfaceSegregation()
   {
      //If online transaction
      if (true)
      {
         OnlineTransaction transaction = new OnlineTransaction();
         transaction.ResolveTransaction();
      }
      else
      {
         InStoreTransaction inStoreTransaction = new InStoreTransaction();
         inStoreTransaction.ResolveTransaction();
      }
   }
}