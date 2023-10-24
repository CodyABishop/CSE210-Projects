public class Product //Class for the foo
{
    private string _name;
    private string _productID; //ID as a string to support ALphanumeric IDs
    private double _price; //Double for decimal prices
    private int _quantity; //Can't purchase partial items, integer quantity.
    public Product(string name, string ID, double price, int quant) //Simple constructor to set the info
    {
        _name = name; 
        _productID = ID;
        _price = price;
        _quantity = quant;
    }
    //Getters
    public string GetName() 
    {
        return _name;
    }
    public string GetID() 
    {
        return _productID;
    }
    public double GetUnitPrice() 
    {
        return _price;
    }
    public int GetQuantity() 
    {
        return _quantity;
    }
    //End Getters
    //Setters
    public void SetName(string name) 
    {
        _name = name;
    }
    public void SetID(string id) 
    {
        _productID = id;
    }
    public void SetPrice(double price) 
    {
        _price = price;
    }
    public void SetQuantity(int quant) 
    {
        _quantity = quant;
    }
    //End Setters
    public double GetSalePrice() 
    {
        return _price*_quantity; //Returns the sale price as price * quantity.
    }
}