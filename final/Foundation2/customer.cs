using System;

public class Customer{
    private string _customerName;
   
    public Address _address;
  

    public Customer(string customerName, Address address){
       _customerName= customerName;
       _address = address;
         
    }

    
    
    public string CustName(){
        return _customerName;
    }
    
    public Address GetAddress(){
        return _address;
    }
    public Boolean CountryFinder(){
        return _address.CountryFinder();
    }
   // public void DisplayCustomer(){
        
     //   Console.WriteLine($"{FirstName} {LastName}");
    //}
}