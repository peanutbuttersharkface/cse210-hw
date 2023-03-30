using System;

public class Product{
    private string _prodName;
    private string _productId;
    
    private double _price;

    private int _quantity;

    public Product( string prodName, string productId, double price, int quantity){
       _prodName = prodName;
       _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public string ProdName(){
    
            return _prodName;
       
    }
    
      public string ProductId(){
        
            return _productId;
        
    }
     
    public double priceOfProduct(){
        return _price * _quantity;
    }

    }
