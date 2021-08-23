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
          Console.WriteLine("\nvendedor não encontrado.\n");
          searchResult = null;
        }
        else
        {
          Console.WriteLine(seller.ToString());
          Console.Write("Tem certeza que deseja deletar este vendedor: (S/N)? ");

          string res = Console.ReadLine();
          if (res.ToLower() == "s")
          {
            sellers.GetSellerList().Remove(seller);

            Console.WriteLine("\nvendedor deletado com sucesso!");
            searchResult = seller;
          }
          Console.WriteLine("");
        }
      }
      else
        System.Console.WriteLine("\nNão há vendedores cadastrados\n");

      return searchResult;
    }
  }
}