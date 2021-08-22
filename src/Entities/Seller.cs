using System;

namespace marketplace.src.Entities
{
  public class Seller : User
  {
    public Seller(int id, string name, string user, string password, DateTime birthDate)
    : base(id, name, user, password, birthDate)
    {
    }
  }
}