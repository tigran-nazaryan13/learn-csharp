public class Building
{
    public string color;
    public int maxcapacity;
    public string location;
    public int price;

    public Building(string guin, int cp, string loc, int gin)
    {
        color = guin;
        maxcapacity = cp;
        location = loc;
        price = gin;
    }
    public void BuyHouse()
    {
        Console.WriteLine("You bought a" + color + "house that has a maximum capacity of" + maxcapacity + "in" + location + "for" + price);
    }
}