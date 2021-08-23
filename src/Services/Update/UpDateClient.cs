using System;
using System.Linq;
using marketplace.src.Entities;
using marketplace.src.Services.Create;

namespace marketplace.src.Services.Update
{
  public class UpDateClient : UpDateUser
  {
    internal void PutClient()
    {
      CreateClient clients = new CreateClient();

      if (clients.GetClientList().Count > 0)
      {
        User user = base.Put();

        if (user != null)
        {
          Client client = clients.GetClientList().FirstOrDefault(c => c._id == user._id);
          Console.WriteLine(client.ToString());

          string res;

          Console.Write("Gostaria de editar o endereço de entrega (S/N)? ");
          res = Console.ReadLine();

          if (res.ToLower() == "s")
            client._deliveryAddress = RegisterAdress("delivery", client._deliveryAddress);

          Console.Write("\nGostaria de editar o endereço de cobrança (S/N)? ");
          res = Console.ReadLine();

          if (res.ToLower() == "s")
            client._billingAddress = RegisterAdress("billing", client._billingAddress);

          Console.WriteLine("\nCliente editado com sucesso!");
          Console.WriteLine(client.ToString());
        }
      }
      else
        Console.WriteLine("\nNão há clientes cadastrados.\n");
    }
    private Address RegisterAdress(string type, Address address)
    {
      string res;

      if (type == "delivery")
        Console.WriteLine("\n[ - Endereço de entrega - ]\n");
      else
        Console.WriteLine("\n[ - Endereço de cobrança - ]\n");

      Console.Write("Gostaria de editar o nome da rua (S/N)? ");
      res = Console.ReadLine();
      if (res.ToLower() == "s")
      {
        Console.Write("Rua: ");
        address.address = Console.ReadLine(); ;
      }

      Console.Write("\nGostaria de editar o complemento (S/N)? ");
      res = Console.ReadLine();
      if (res.ToLower() == "s")
      {
        Console.Write("Complemento: ");
        address.secondAddress = Console.ReadLine();
      }

      Console.Write("\nGostaria de editar o CEP (S/N)? ");
      res = Console.ReadLine();
      if (res.ToLower() == "s")
      {
        Console.Write("CEP: ");
        address.zipCode = Console.ReadLine();
      }

      Console.Write("\nGostaria de editar a cidade (S/N)? ");
      res = Console.ReadLine();
      if (res.ToLower() == "s")
      {
        Console.Write("Cidade: ");
        address.city = Console.ReadLine();
      }

      Console.Write("\nGostaria de editar o Estado (S/N)? ");
      res = Console.ReadLine();
      if (res.ToLower() == "s")
      {
        Console.Write("Estado: ");
        address.state = Console.ReadLine();
      }

      Console.Write("\nGostaria de editar o País (S/N)? ");
      res = Console.ReadLine();
      if (res.ToLower() == "s")
      {
        Console.Write("País: ");
        address.country = Console.ReadLine();
      }
      return address;
    }
  }
}