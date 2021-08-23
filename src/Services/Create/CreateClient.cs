using System;
using System.Linq;
using System.Collections.Generic;
using marketplace.src.Entities;

namespace marketplace.src.Services.Create
{
  public class CreateClient : CreateUser
  {
    static private List<Client> clientList = new List<Client>();
    protected internal void RegisterClient()
    {
      if (GetUserList().Count > 0)
      {
        Console.Write("Digite o id do usuário que deseja cadastrar como cliente: ");
        int userId;
        while (!int.TryParse(Console.ReadLine(), out userId))
        {
          Console.WriteLine("\nId inválido!");
          Console.Write("Digite o id do usuário que deseja cadastrar como cliente: ");
        }

        User user = GetUserList().FirstOrDefault(u => u._id == userId);

        if (user != null)
        {
          Address deliveryAddress = RegisterAdress("delivery");
          Address billingAddress = RegisterAdress("billing");

          Client client = new Client(user._id, user._name, user._user, user._password, user._birthDate, deliveryAddress, billingAddress);
          clientList.Add(client);

          Console.WriteLine("\nCliente cadastrado com sucesso!");
          Console.WriteLine(client.ToString());
        }
        else
          Console.WriteLine("\nUsuário não encontrado.\n");
      }
      else
        Console.WriteLine("\nPara cadastrar um cliente primeiro deve cadastra-lo como usuário\n");
    }

    private Address RegisterAdress(string type)
    {
      Address adress = new Address();

      if (type == "delivery")
        Console.WriteLine("\nEndereço de entrega");
      else
        Console.WriteLine("\nEndereço de cobrança");

      Console.Write("Rua: ");
      adress.address = Console.ReadLine();

      Console.Write("Número: ");
      int addressAux;
      while (!int.TryParse(Console.ReadLine(), out addressAux))
      {
        Console.WriteLine("Número inválido!");
        Console.Write("Número: ");
      }
      adress.number = addressAux;

      Console.Write("Complemento: ");
      adress.secondAddress = Console.ReadLine();

      Console.Write("CEP: ");
      adress.zipCode = Console.ReadLine();

      Console.Write("Cidade: ");
      adress.city = Console.ReadLine();

      Console.Write("UF: ");
      adress.state = Console.ReadLine();

      Console.Write("País: ");
      adress.country = Console.ReadLine();

      return adress;
    }
    public List<Client> GetClientList()
    {
      return clientList;
    }
  }
}