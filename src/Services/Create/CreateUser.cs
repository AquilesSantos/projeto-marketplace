using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using marketplace.src.Entities;

namespace marketplace.src.Services.Create
{
  public class CreateUser
  {
    static private List<User> userList = new List<User>();
    protected internal User RegisterUser()
    {
      Console.Write("\nNome: ");
      string name = Console.ReadLine();
      while (!Regex.IsMatch(name, @"^[a-zA-Z ]+$"))
      {
        Console.WriteLine("Neste campo só permite letras.\n");
        Console.Write("Nome: ");
        name = Console.ReadLine();
      }

      Console.Write("Username: ");
      string userName = Console.ReadLine();

      Console.Write("Password: ");
      string password = Console.ReadLine();

      Console.Write("Data de nascimento: ");
      DateTime birthDate;
      while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
      {
        Console.WriteLine("\nData inválida!");
        Console.Write("Data de nascimento: ");
      }
      return AddUser(name, userName, password, birthDate);
    }

    private User AddUser(string name, string userName, string password, DateTime birthDate)
    {
      int userId;

      if (GetUserList().Count > 0)
        userId = GetUserList()[GetUserList().Count - 1]._id + 1;
      else
        userId = 1;

      User user = new User(userId, name, userName, password, birthDate);
      userList.Add(user);

      Console.WriteLine("\nUsuário cadastrado com sucesso!");
      Console.WriteLine(user.ToString());
      return user;
    }

    public List<User> GetUserList()
    {
      return userList;
    }
  }
}