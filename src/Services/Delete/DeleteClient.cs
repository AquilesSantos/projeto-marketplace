using System;
using System.Linq;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Delete
{
  public class DeleteClient
  {
    internal void DelClient()
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
          Console.WriteLine("\nCliente não encontrado.\n");
          searchResult = null;
        }
        else
        {
          Console.WriteLine(client.ToString());
          Console.Write("Tem certeza que deseja deletar este cliente: (S/N)? ");

          string res = Console.ReadLine();
          if (res.ToLower() == "s")
          {
            clients.GetClientList().Remove(client);

            Console.WriteLine("\nCliente deletado com sucesso!");
            searchResult = client;
          }
          Console.WriteLine("");
        }
      }
      else
        System.Console.WriteLine("\nNão há clientes cadastrados\n");
    }
  }
}