using System;
using System.Linq;
using System.Collections.Generic;
using marketplace.src.Entities;

namespace marketplace.src.Services.Create
{
  public class CreateSeller : CreateUser
  {
    static private List<Seller> sellerList = new List<Seller>();
    public void RegisterSeller()
    {
      if (GetUserList().Count > 0)
      {
        Console.Write("Digite o id do usuário que deseja cadastrar como vendedor: ");
        int userId;
        while (!int.TryParse(Console.ReadLine(), out userId))
        {
          Console.WriteLine("\nId inválido!");
          Console.Write("Digite o id do usuário que deseja cadastrar como vendedor: ");
        }

        User user = GetUserList().FirstOrDefault(u => u._id == userId);

        if (user != null)
        {
          Seller seller = new Seller(user._id, user._name, user._user, user._password, user._birthDate);
          sellerList.Add(seller);

          Console.WriteLine("\nVendedor cadastrado com sucesso!\n");
        }
        else
          Console.WriteLine("\nUsuário não encontrado.\n");
      }
      else
        Console.WriteLine("\nPara cadastrar um vendedor primeiro deve cadastra-lo como usuário\n");
    }

    public List<Seller> GetSellerList()
    {
      return sellerList;
    }
  }
}