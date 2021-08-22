using System;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Search
{
  public class ViewUserList
  {
    public void Get()
    {
      CreateUser users = new CreateUser();
      if (users.GetUserList().Count > 0)
      {
        foreach (User user in users.GetUserList())
          Console.WriteLine(user);
      }
      else
        Console.WriteLine("\nNão há usuários cadastrados\n");
    }
  }
}