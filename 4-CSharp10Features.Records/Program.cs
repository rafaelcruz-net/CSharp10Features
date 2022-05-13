
var p1 = new Person1
{
    Name = "Johnny Hooyberghs",
    Age = 36
};

Console.WriteLine(p1);

var p2 = new Person2("Johnny Hooyberghs", 36);

Console.WriteLine(p2);

var p3 = p2 with { Age = 25 };

Console.WriteLine(p3);

var p4 = new Person4("Johnny Hooyberghs", 36);
p4.Age++;
Console.WriteLine(p4);

var p5 = new Person5("Johnny Hooyberghs", 36);
Console.WriteLine(p5);

var p7 = p1 with { Age = 36 };
Console.WriteLine(p7 == p1); // Vai print true ou false mas consigo fazer a comparacao por valor


var p6 = new Person6("Johnny Hooyberghs", 37);
Console.WriteLine(p6);

var p8 = new Person6("Johnny Hooyberghs", 37); ;
Console.WriteLine(p8);

Console.WriteLine(p6 == p8); //



// Record classes

public record Person1
{
    public string Name { get; init; }
    public byte Age { get; init; }
}

public record Person2(string Name, byte Age);

public record class Person3(string Name, byte Age)
{
    public void Birtday()
    {
        //Age++;
    }
}

// Record structs

public record struct Person4(string Name, byte Age)
{
    public void Birtday()
    {
        Age++;
    }
}

public readonly record struct Person5(string Name, byte Age)
{
    public void Birtday()
    {
        //Age++;
    }
}

public class Person6
{
    public String Name { get; set; }
    public byte Age { get; set; }

    public Person6(string name, byte age)
    {
        this.Name = name;
        this.Age = age;
    }

    
}