using System;
using System.Linq;
using System.Collections.Generic;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Delete
{
  public class DeleteUser
  {
    public User DelUser()
    {
      User user;
      User searchResult = null;
      CreateUser users = new CreateUser();
      CreateClient clients = new CreateClient();
      CreateSeller sellers = new CreateSeller();

      if (users.GetUserList().Count > 0)
      {
        Console.Write("Digite o id do usuário que deseja excluir: ");
        int userId;
        while (!int.TryParse(Console.ReadLine(), out userId))
        {
          Console.WriteLine("\nId inválido!");
          Console.Write("Digite o id do usuário que deseja excluir: ");
        }

        user = users.GetUserList().FirstOrDefault(u => u._id == userId);

        if (user == null)
        {
          Console.WriteLine("\nUsuário não encontrado\n");
          searchResult = null;
        }
        else
        {
          users.GetUserList().Remove(user);

          Console.WriteLine("\nUsuário deletado com sucesso!\n");
          searchResult = user;

          if (clients.GetClientList().Count > 0)
          {
            Client client = clients.GetClientList().FirstOrDefault(c => c._id == userId);
            if (client != null)
              clients.GetClientList().Remove(client);
          }
          if (sellers.GetSellerList().Count > 0)
          {
            Seller seller = sellers.GetSellerList().FirstOrDefault(s => s._id == userId);
            if (seller != null)
              sellers.GetSellerList().Remove(seller);
          }
        }
      }
      else
        System.Console.WriteLine("\nNão há usuários cadastrados\n");

      return searchResult;
    }
  }
}