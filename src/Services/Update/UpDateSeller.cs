using System;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Update
{
  public class UpDateSeller : UpDateUser
  {
    protected internal void PutSeller()
    {
      CreateSeller sellers = new CreateSeller();
      if (sellers.GetSellerList().Count > 0)
      {
        User user = base.Put();
        if (user != null)
        {
          Console.WriteLine($"\nvendedor editado com sucesso!");
          Console.WriteLine(user.ToString());
        }
      }
      else
        Console.WriteLine("\nNão há vendedores cadastrados\n");
    }
  }
}