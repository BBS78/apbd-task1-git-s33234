using System;

class Cat
{
    string? name;
    int? age;
    string? gender;
    string? favouriteFood;
    Cat[]? parents = new Cat[2];

    public Cat(string name, int age, string gender, string favouriteFood, Cat[] parents)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.favouriteFood = favouriteFood;
        this.parents = parents;
    }

    public Cat(string name, int age, string gender, Cat[] parents)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.parents = parents;

        favouriteFood = this.InharitTaste();

    }

    public Cat() {
        this.name = null;
        this.age = null;
        this.gender = null;
        this.favouriteFood = null;
        this.parents = null;
    }

    void Eat(string food)
    {
        Console.Write(name + " has been fed and ");

        if (food == favouriteFood)
            Console.WriteLine("liked that.");
        else
            Console.WriteLine("didn't like that.");
    }

    void PrintInfo() {
        Console.WriteLine($"Name: {name}\n" +
            $"Age: {age}\n" +
            $"Gender: {gender}\n"+
            $"Favourite Food: {favouriteFood}\n" +
            $"Parents: {parents[0].name}, {parents[1].name}");
    }

    string InharitTaste() {
        Random random = new Random();
        int i = random.Next(0, 2);
        return parents[i].favouriteFood;
    }


    static void Main(string[] args)
    {
        Cat mom = new Cat("Nina", 20, "female", "fish", [new Cat(), new Cat()]);
        Cat dad = new Cat("Alan", 22, "male", "pizza", [new Cat(), new Cat()]);

        Cat child = new Cat("Tom", 4, "male", [mom, dad]);
        child.Eat("fish");
        child.Eat("pizza");


        child.PrintInfo();
    }
}