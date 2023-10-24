public class Address
{
    private string _streetAddr;
    private string _city;
    private string _stateProv;
    private string _country;
    public Address(string street, string city, string stateProv, string country) //Simple constructor to set the address info
    {
        _streetAddr = street;
        _city = city;
        _stateProv = stateProv;
        _country = country;
    }
    //Getters
    public string GetStreetAddress() 
    {
        return _streetAddr;
    }
    public string GetCity() 
    {
        return _city;
    }
    public string GetState() 
    {
        return _stateProv;
    }
    public string GetCountry() 
    {
        return _country;
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
    public void SetState(string stateProv) 
    {
        _stateProv = stateProv;
    }
    public void SetCountry(string country) 
    {
        _country = country;
    }
    //End Setters
    public bool CheckUS() //Checks accepted spellings of US for the country, returns false otherwise.
    {
        if(_country == "US"){
            return true;
        } else if(_country == "USA"){
            return true;
        } if(_country == "United States"){
            return true;
        } if(_country == "United States of America"){
            return true;
        } else{
            return false;
        }
    }
    public string GetAddressInfo() 
    {
        return ($"{_streetAddr}\n{_city}, {_stateProv}.\n{_country}"); //Returns the adress as a formatted string.
    }
}