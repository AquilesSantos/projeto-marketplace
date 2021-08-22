using System;
using System.Linq;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Delete
{
  public class DeleteClient
  {
    public Client DelClient()
    {
      Client client;
      Client searchResult = null;
      CreateClient clients = new CreateClient();

      if (clients.GetClientList().Count > 0)
      {

        Console.Write("Digite o id do cliente de deseja excluir: ");
        int clientId;
        while (!int.TryParse(Console.ReadLine(), out clientId))
        {
          Console.WriteLine("\nId inválido!");
          Console.Write("Digite o id do cliente de deseja excluir: ");
        }

        client = clients.GetClientList().FirstOrDefault(u => u._id == clientId);

        if (client == null)
        {
          Console.WriteLine("\nClientes não encontrado.\n");
          searchResult = null;
        }
        else
        {
          clients.GetClientList().Remove(client);

          Console.WriteLine("\nCliente deletado com sucesso!\n");
          searchResult = client;
        }
      }
      else
        System.Console.WriteLine("\nNão há clientes cadastrados\n");

      return searchResult;
    }
  }
}