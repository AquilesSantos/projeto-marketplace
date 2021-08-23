using System;
using System.Linq;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Search
{
  public class SearchUser
  {
    internal string Get()
    {
      CreateUser users = new CreateUser();
      string searchResult = "";

      if (users.GetUserList().Count > 0)
      {
        Console.Write("Digite o id do usuário que deseja buscar: ");
        int userId;
        while (!int.TryParse(Console.ReadLine(), out userId))
        {
          Console.WriteLine("\nId inválido!");
          Console.Write("Digite o id do usuário que deseja buscar: ");
        }

        User user = users.GetUserList().FirstOrDefault(u => u._id == userId);

        if (user == null)
          searchResult = "\nUsuário não encontrato\n";
        else
          searchResult = user.ToString();
      }
      else
        searchResult = "\nNão há usuários cadastrados\n";

      return searchResult;
    }
  }
}