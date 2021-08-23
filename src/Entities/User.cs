using System;

namespace marketplace.src.Entities
{
  public class User
  {
    public int _id { get; internal set; }
    public string _name { get; internal set; }
    public string _user { get; internal set; }
    public string _password { get; internal set; }
    public DateTime _birthDate { get; internal set; }

    public User() { }
    public User(int id, string name, string user, string password, DateTime birthDate)
    {
      _id = id;
      _name = name;
      _user = user;
      _password = password;
      _birthDate = birthDate;
    }

    public override string ToString()
    {
      return $@"
       ID: {_id} 
       Name: {_name} 
       User: {_user}
       Password: {_password}
       BirthDate: {_birthDate.ToString("dd/MM/yyyy")}
       ";
    }
  }
}