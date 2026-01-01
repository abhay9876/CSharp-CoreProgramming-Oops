/*1. Animal Hierarchy
Description:
Create a hierarchy where Animal is the superclass, and Dog, Cat, and Bird are subclasses.
Each subclass has a unique behavior.
Tasks:
1. Define a superclass Animal:
o Add two attributes: Name (string) and Age (integer).
o Add a method MakeSound() that provides a generic sound message (e.g.,
"Animal makes a sound").
2. Define subclasses Dog, Cat, and Bird:
o Each subclass should override the MakeSound() method to provide its unique
behavior (e.g., "Dog barks", "Cat meows", "Bird chirps").

3. Goal:
o Learn basic inheritance, method overriding, and polymorphism by calling
MakeSound() on instances of different subclasses.*/


using System;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    // Virtual method 
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Dog Class
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }

    // Override the method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Cat Class
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

// Bird Class
class Bird : Animal
{
    public Bird(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}
