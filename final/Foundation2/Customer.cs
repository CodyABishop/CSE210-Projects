public class Customer //Class for the Customer
{
    private string _name; //Customer name
    private Address _address; //Address item, private and not returned directly.
    public Customer(string name, Address addr) //Simple constructor to set the info
    {
        _name = name;
        _address = addr;
    }
    public Customer(string name, string street, string city, string stateProv, string country) //Alternate constructor
    {
        _name = name;
        _address = new(street, city, stateProv, country); //Instantiates a new Adress object directly
    }
    //Getters
    public string GetCustomerName() 
    {
        return _name;
    }
    public string GetCustomerAddress() 
    {
        return _address.GetAddressInfo();
    }
    public bool GetUSAStatus() 
    {
        return _address.CheckUS();
    }
    //End Getters
    //Setters
    public void SetName(string name) 
    {
        _name = name;
    }
    public void SetAddress(Address addr) 
    {
        _address = addr;
    }
    //End Setters
}