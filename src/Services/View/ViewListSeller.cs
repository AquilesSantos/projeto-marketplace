using System;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Search
{
  public class ViewListSeller
  {
    internal void Get()
    {
      CreateSeller sellers = new CreateSeller();
      if (sellers.GetSellerList().Count > 0)
      {
        foreach (User seller in sellers.GetSellerList())
          Console.WriteLine(seller);
      }
      else
        Console.WriteLine("\nNão há vendedores cadastrados\n");
    }
  }
}