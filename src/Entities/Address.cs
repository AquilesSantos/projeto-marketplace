namespace marketplace.src.Entities
{
  public class Address
  {
    public string address { get; set; }

    public string secondAddress { get; set; }

    public int number { get; set; }

    public string zipCode { get; set; }

    public string city { get; set; }

    public string state { get; set; }

    public string country { get; set; }

    public override string ToString()
    {
      return $@"
       
       addres: {address}
       secondAddress: {secondAddress}
       number: {number}
       zipCode: {zipCode}
       city: {city}
       state: {state}
       coutry: {country}
       ";
    }
  }
}