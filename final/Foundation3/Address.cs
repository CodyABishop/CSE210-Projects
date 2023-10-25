public class Address
{
    private string _streetAddr;
    private string _city;
    private string _state;
    public Address(string street, string city, string state) //Simple constructor to set the address info
    {
        _streetAddr = street;
        _city = city;
        _state = state;
    }
    //Getters
    public string GetStreet() 
    {
        return _streetAddr;
    }
    public string GetCity() 
    {
        return _city;
    }
    public string GetState() 
    {
        return _state;
    }
    //End Getters
    //Setters
    public void SetStreetAddress(string addr) 
    {
        _streetAddr = addr;
    }
    public void SetCity(string city) 
    {
        _city = city;
    }
    public void SetState(string state) 
    {
        _state = state;
    }
    public string Display(){
        return($"{_streetAddr}. {_city}, {_state}.");
    }
}