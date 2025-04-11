using System;

public class Address
{
    private string street;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string street, string city, string stateProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public string GetStreet() => street;
    public string GetCity() => city;
    public string GetStateProvince() => stateProvince;
    public string GetCountry() => country;

    public bool IsInRSA() => country.ToLower() == "rsa";

    public override string ToString()
    {
        return $"{GetStreet()}\n{GetCity()}, {GetStateProvince()}\n{GetCountry()}";
    }
}