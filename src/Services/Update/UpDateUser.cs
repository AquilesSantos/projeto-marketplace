using System;
using System.Linq;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Update
{
  public class UpDateUser
  {
    public User Put()
    {
      User user;
      User searchResult = null;
      CreateUser users = new CreateUser();
      CreateClient clients = new CreateClient();
      CreateSeller sellers = new CreateSeller();

      if (users.GetUserList().Count > 0)
      {
        Console.Write("Digite o id do usuário que deseja editar: ");
        int userId;
        while (!int.TryParse(Console.ReadLine(), out userId))
        {
          Console.WriteLine("\nId inválido!");
          Console.Write("Digite o id do usuário que deseja editar: ");
        }

        user = users.GetUserList().FirstOrDefault(u => u._id == userId);

        if (user == null)
        {
          searchResult = null;
          Console.WriteLine("\nUsuário não encontrado\n");
        }
        else
        {
          searchResult = EditData(user);

          if (Menu.resOptionMenu == 11)
          {
            Console.WriteLine("\nUsuário editado com sucesso!");
            Console.WriteLine(user.ToString());
          }

          if (clients.GetClientList().Count > 0)
          {
            Client client = clients.GetClientList().FirstOrDefault(c => c._id == user._id);
            client._name = searchResult._name;
            client._user = searchResult._user;
            client._password = searchResult._password;
            client._birthDate = searchResult._birthDate;
          }

          if (sellers.GetSellerList().Count > 0)
          {
            Seller seller = sellers.GetSellerList().FirstOrDefault(c => c._id == user._id);
            seller._name = searchResult._name;
            seller._user = searchResult._user;
            seller._password = searchResult._password;
            seller._birthDate = searchResult._birthDate;
          }
        }
      }
      else
      {
        Console.WriteLine("\nNão há usuários cadastrados\n");
        searchResult = null;
      }

      return searchResult;
    }
    public User EditData(User user)
    {
      string res;

      Console.Write("\nGostaria de editar o nome: (S/N)? ");
      res = Console.ReadLine();
      if (res.ToLower() == "s")
      {
        Console.Write("Digite o nome: ");
        user._name = Console.ReadLine(); ;
      }

      Console.Write("\nGostaria de editar o userName: (S/N)? ");
      res = Console.ReadLine();
      if (res.ToLower() == "s")
      {
        Console.Write("Digite o userName: ");
        user._user = Console.ReadLine(); ;
      }

      Console.Write("\nGostaria de editar a senha: (S/N)? ");
      res = Console.ReadLine();
      if (res.ToLower() == "s")
      {
        Console.Write("Digite a senha: ");
        user._password = Console.ReadLine(); ;
      }

      Console.Write("\nGostaria de editar a data de nascimento: (S/N)? ");
      res = Console.ReadLine();
      if (res.ToLower() == "s")
      {
        Console.Write("Digite a data de nascimento: ");
        user._birthDate = DateTime.Parse(Console.ReadLine()); ;
      }

      return user;
    }
  }
}