public class Food
{
    public string color;
    public string type;
    public string size;

    public Food(string clor, string tpe, string sze)
    {
        color = clor;
        type = tpe;
        size = sze;
    }

    public void EatFood()
    {
        Console.WriteLine("You just ate a" + " " + color + " " + type + " " + "which is a" + " " + size + " "+ "size");
    } 
}