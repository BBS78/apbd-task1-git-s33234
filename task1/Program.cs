using System;

class Cat
{
    string name;
    int age;
    string gender;
    string favouriteFood;

    public Cat(string name, int age, string gender, string favouriteFood)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.favouriteFood = favouriteFood;
    }

    void Eat(string food)
    {
        Console.Write(name + " has been fed and ");

        if (food == favouriteFood)
            Console.Write("liked that.");
        else
            Console.Write("didn't like that.");
    }

    static void Main(string[] args)
    {
        Cat c = new Cat("Tom", 4, "male", "fish");
        c.Eat("pizza");
    }
}