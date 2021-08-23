using System;
using System.Linq;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Search
{
  public class SearchSeller
  {
    public string Get()
    {
      CreateSeller sellers = new CreateSeller();
      string searchResult = "";

      if (sellers.GetSellerList().Count > 0)
      {
        Console.Write("Digite o id do vendedor que deseja buscar: ");
        int sellerId;
        while (!int.TryParse(Console.ReadLine(), out sellerId))
        {
          Console.WriteLine("\nId inválido!");
          Console.Write("Digite o id do vendedor que deseja buscar: ");
        }

        User seller = sellers.GetSellerList().FirstOrDefault(s => s._id == sellerId);

        if (seller == null)
          searchResult = "\nVendedor não encontrato\n";
        else
          searchResult = seller.ToString();
      }
      else
        searchResult = "\nNão há vendedores cadastrados\n";

      return searchResult;
    }
  }
}