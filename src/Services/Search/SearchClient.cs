using System;
using System.Linq;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Search
{
  public class SearchClient
  {
    internal string Get()
    {
      CreateClient clients = new CreateClient();
      string searchResult = "";

      if (clients.GetClientList().Count > 0)
      {
        Console.Write("Digite o id do cliente que deseja buscar: ");
        int clientId;
        while (!int.TryParse(Console.ReadLine(), out clientId))
        {
          Console.WriteLine("\nId inválido!");
          Console.Write("Digite o id do cliente que deseja buscar: ");
        }

        Client client = clients.GetClientList().FirstOrDefault(c => c._id == clientId);

        if (client == null)
          searchResult = "\nCliente não encontrato\n";
        else
          searchResult = client.ToString();
      }
      else
        searchResult = "\nNão há clientes cadastrados\n";

      return searchResult;
    }
  }
}