public class Person
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }

    public Person(int id, int age, string name)
    {
        Id = id;
        Age = age;
        Name = name;
    }

    public Person()
    {
    }
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}";
    }
}
