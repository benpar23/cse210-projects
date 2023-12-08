public class Address    
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public string GetAddressString()
    {
        return $"{_streetAddress}\r\n{_city}, {_state}\r\n{_country}";
    }
}