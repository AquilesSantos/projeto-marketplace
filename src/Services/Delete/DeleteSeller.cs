using System;
using System.Linq;
using System.Collections.Generic;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Delete
{
  public class DeleteSeller
  {
    public Seller DelSeller()
    {
      Seller seller;
      Seller searchResult = null;
      CreateSeller sellers = new CreateSeller();

      if (sellers.GetSellerList().Count > 0)
      {

        Console.Write("Digite o id do vendedor de deseja excluir: ");
        int sellerId;
        while (!int.TryParse(Console.ReadLine(), out sellerId))
        {
          Console.WriteLine("\nId inválido!");
          Console.Write("Digite o id do vendedor de deseja excluir: ");
        }

        seller = sellers.GetSellerList().FirstOrDefault(u => u._id == sellerId);

        if (seller == null)
        {
          Console.WriteLine("\nvendedors não encontrado.\n");
          searchResult = null;
        }
        else
        {
          sellers.GetSellerList().Remove(seller);

          Console.WriteLine("\nvendedor deletado com sucesso!\n");
          searchResult = seller;
        }
      }
      else
        System.Console.WriteLine("\nNão há vendedores cadastrados\n");

      return searchResult;
    }
  }
}