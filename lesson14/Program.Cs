class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.walk();
        myDog.eat();
        myDog.drink();
        myDog.ruff();

        Cat myCat = new Cat();
        myCat.walk();
        myCat.eat();
        myCat.drink();
        myCat.meow();

        Cow myCow = new Cow();
        myCow.walk();
        myCow.eat();
        myCow.drink();
        myCow.moo();

        GermanShepard myGS = new GermanShepard();
        myGS.fight();
        myGS.ruff();
        myGS.walk();
        myGS.eat();
        myGS.drink();
    }
}

