using System;

namespace marketplace.src.Entities
{
  public class Client : User
  {
    public Address _deliveryAddress { get; internal set; }
    public Address _billingAddress { get; internal set; }
    public Client(
      int id, string name, string user, string password, DateTime birthDate, Address deliveryAddress, Address billingAddress) :
      base(id, name, user, password, birthDate)
    {
      _deliveryAddress = deliveryAddress;
      _billingAddress = billingAddress;
    }

    public override string ToString()
    {
      return $@"
       ID: {_id} 
       Name: {_name} 
       User: {_user}
       Password: {_password}
       BirthDate: {_birthDate.ToString("dd/MM/yyyy")}       
       
       [ - DeliveryAddress - ] {_deliveryAddress}
       
       [ - BillingAddress - ] {_billingAddress}
       ";
    }
  }
}