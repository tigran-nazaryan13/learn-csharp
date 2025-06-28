public class Program
{
    static void Main(string[] args)
    {
        Food food1 = new Food("red", "apple", "medium");
        food1.EatFood();

        Car MyCar = new Car();
        MyCar.honk();
        Console.WriteLine(MyCar.brand + " " + MyCar.modelName);


        Breakfast myBreakfast = new Breakfast();
        Console.WriteLine("You ate breakfast at" + " " + myBreakfast.time);
        }
}