using System;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Update
{
  public class UpDateSeller : UpDateUser
  {
    public void PutSeller()
    {
      CreateSeller sellers = new CreateSeller();
      if (sellers.GetSellerList().Count > 0)
      {
        base.Put();
        Console.WriteLine("\nVendedor editado com sucesso\n");

      }
      else
        Console.WriteLine("\nNão há vendedores cadastrados\n");
    }
  }
}