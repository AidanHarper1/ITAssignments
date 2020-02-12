using System;
namespace DogChallenge
{
public enum Gender{male,female};
class Dog
{
public string name;
public string owner;
public int age;
public Gender gender;
// constructor
public Dog(string name, string owner, int age, Gender gender)
{
    this.name = name;
    this.owner = owner;
    this.age = age;
    this.gender = gender;
} 
// method bark
public void Bark(int times)
{
    for(int i=0; i<=times;i++)
    {
        Console.WriteLine("Woof!");
    }
}
// method dog tag
public string GetTag()
{
    string tag = "If lost, call "+owner+".";
    if (gender == Gender.male)
    {
        tag += " His name is " +name+ " he is " + age.ToString();
    }
    else
    {
        tag += " Her name is "+name+ " she is " + age.ToString();
    }
    if (age>1)
    {
        tag+= " years old.";
    }
    else
    {
        tag+= " year old.";
    }
    return tag;
}
}
class Program{
    static void Main(string[] args)
    {
        var puppy = new Dog("Orion", "Shawn", 1, Gender.male);  // create object instance
        puppy.Bark(3); // output: Woof!Woof!Woof!
        Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

        var myDog = new Dog("Lileu", "Dale", 4, Gender.female);  // create object instance
        myDog.Bark(1); // output: Woof!
        Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.

    }
    }   
    }
