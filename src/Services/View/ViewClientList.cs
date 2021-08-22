using System;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Search
{
  public class ViewClientList
  {
    public void Get()
    {
      CreateClient clients = new CreateClient();
      if (clients.GetClientList().Count > 0)
      {
        foreach (User client in clients.GetClientList())
          Console.WriteLine(client);
      }
      else
        Console.WriteLine("\nNão há clientes cadastrados\n");
    }
  }
}