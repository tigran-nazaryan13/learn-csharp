public class Program
{
    static void Main(string[] args)
    {
        Car myObj = new Car();
        myObj.color = "red";
        myObj.maxSpeed = 200;
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.maxSpeed);

        Human human1 = new Human();
        human1.skincolor = "black";
        human1.age = 17;
        Console.WriteLine(human1.skincolor);
        Console.WriteLine(human1.age);

        Human human2 = new Human();
        human2.skincolor = "green";
        human2.age = 84;
        Console.WriteLine(human2.skincolor);
        Console.WriteLine(human2.age);
        human2.sayHello();
        human1.sayHello();
        myObj.unlockCar();

        Animal animal1 = new Animal();
        animal1.type = "cat";
        animal1.age = 5;
        animal1.sound = "meow";
        animal1.sayHi();

        // Building building1 = new Building();
        // building1.color = "red";
        // building1.maxcapacity = 40;
        // building1.location = "New York";
        // building1.price = 10000000;
        // building1.BuyHouse();

        Building building2 = new Building("green", 20, "Washington DC", 100000);
        building2.BuyHouse();

        Building building3 = new Building("purple", 10, "Long Beach", 50000);
        building3.BuyHouse();

      
    }
}