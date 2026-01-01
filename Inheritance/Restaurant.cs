/*Restaurant Management System with Hybrid
Inheritance

○ Description: Model a restaurant system where Person is the superclass and
Chef and Waiter are subclasses. Both Chef and Waiter should implement a
Worker interface that requires a PerformDuties() method.
○ Tasks:
■ Define a superclass Person with attributes like Name and Id.
■ Create an interface Worker with a method PerformDuties().
■ Define subclasses Chef and Waiter that inherit from Person and
implement the Worker interface, each providing a unique implementation
of PerformDuties().

○ Goal: Practice hybrid inheritance by combining inheritance and interfaces, giving
multiple behaviors to the same objects.*/




using System;

class Person1
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Person1(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

// create interface
interface Worker
{
    void PerformDuties();
}


// Class chef --Acquire the properties of Parent class and interface
class Chef : Person1, Worker
{
    public Chef(int id, string name) : base(id, name)
    {
    }

    public void PerformDuties()
    {
        Console.WriteLine($"Chef {Name} is preparing food.");
    }
}

// Waiter classs
class Waiter : Person1, Worker
{
    public Waiter(int id, string name) : base(id, name)
    {
    }

    public void PerformDuties()
    {
        Console.WriteLine($"Waiter {Name} is serving customers.");
    }
}


