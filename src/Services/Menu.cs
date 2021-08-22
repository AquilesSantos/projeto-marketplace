using System;
using marketplace.src.Services.Create;
using marketplace.src.Services.Search;
using marketplace.src.Services.Update;
using marketplace.src.Services.Delete;

namespace marketplace.src.Services
{
  public class Menu
  {
    public static int resOptionMenu;
    public void Options()
    {
      string[] options = {
        "\nBem vindo ao sistema de marketplace",
        "Observe o menu e escolha o número da opção desejada",
        "\n[ 01 ] - Cadastrar Novo Usuário",
        "\n[ 02 ] - Cadastrar Novo Vendedor",
        "\n[ 03 ] - Cadastrar Novo Cliente",
        "\n[ 04 ] - Exibir lista de Usuários",
        "\n[ 05 ] - Exibir lista de Vendedores",
        "\n[ 06 ] - Exibir lista de Clientes",
        "\n[ 07 ] - Buscar Usuário",
        "\n[ 08 ] - Buscar Vendedor",
        "\n[ 09 ] - Buscar Cliente",
        "\n[ 10 ] - Atualizar dados Usuário",
        "\n[ 11 ] - Atualizar dados Vendedor",
        "\n[ 12 ] - Atualizar dados Cliente",
        "\n[ 13 ] - Deletar dados Usuário",
        "\n[ 14 ] - Deletar dados Vendedor",
        "\n[ 15 ] - Deletar dados Cliente",
        "\n[ 16 ] - Sair",
        };

      foreach (string op in options)
        Console.WriteLine(op);

      Console.Write("\nOpção: ");
    }
    public void DefaultMessage()
    {
      Console.Write("Tecle qualquer botão para retornar ao menu: ");
      Console.ReadLine();
    }
    public void InvalidOption()
    {
      Console.WriteLine("\nOpção inválida!");
      DefaultMessage();
    }
    public void GeneralMenuOption()
    {
      bool exit = false;

      do
      {
        Options();

        while (!int.TryParse(Console.ReadLine(), out resOptionMenu))
        {
          InvalidOption();
          Options();
        }

        switch (resOptionMenu)
        {
          case 1:
            CreateUser createUser = new CreateUser();
            createUser.RegisterUser();
            DefaultMessage();
            break;
          case 2:
            CreateSeller createSeller = new CreateSeller();
            createSeller.RegisterSeller();
            DefaultMessage();
            break;
          case 3:
            CreateClient createClient = new CreateClient();
            createClient.RegisterClient();
            DefaultMessage();
            break;
          case 4:
            ViewUserList viewUserList = new ViewUserList();
            viewUserList.Get();
            DefaultMessage();
            break;
          case 5:
            ViewListSeller viewListSeller = new ViewListSeller();
            viewListSeller.Get();
            DefaultMessage();
            break;
          case 6:
            ViewClientList viewClientList = new ViewClientList();
            viewClientList.Get();
            DefaultMessage();
            break;
          case 7:
            SearchUser searchUser = new SearchUser();
            Console.WriteLine(searchUser.Get());
            DefaultMessage();
            break;
          case 8:
            SearchSeller searchSeller = new SearchSeller();
            Console.WriteLine(searchSeller.Get());
            DefaultMessage();
            break;
          case 9:
            SearchClient searchClient = new SearchClient();
            Console.WriteLine(searchClient.Get());
            DefaultMessage();
            break;
          case 10:
            UpDateUser updateUser = new UpDateUser();
            updateUser.Put();
            DefaultMessage();
            break;
          case 11:
            UpDateSeller updateSeller = new UpDateSeller();
            updateSeller.PutSeller();
            DefaultMessage();
            break;
          case 12:
            UpDateClient updateClient = new UpDateClient();
            updateClient.PutClient();
            DefaultMessage();
            break;
          case 13:
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.DelUser();
            DefaultMessage();
            break;
          case 14:
            DeleteSeller deleteSeller = new DeleteSeller();
            deleteSeller.DelSeller();
            DefaultMessage();
            break;
          case 15:
            DeleteClient deleteClient = new DeleteClient();
            deleteClient.DelClient();
            DefaultMessage();
            break;
          case 16:
            exit = true;
            break;
          default:
            InvalidOption();
            break;
        }
      }
      while (!exit);
    }
  }
}