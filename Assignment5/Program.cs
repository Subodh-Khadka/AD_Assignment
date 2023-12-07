using System;

public class Student
{
    private string name;
    private int age;
    private string major;

    public Student(string name, int age, string major)
    {
        this.name = name;
        this.age = age;
        this.major = major;
    }

    public void Introduce()
    {
        Console.WriteLine("My name is " + name + ", I am " + age + " years old, and I am majoring in " + major + ".");
    }
}

public class Program
{
    public static void Main()
    {
        Student myStudent = new Student("John Doe", 20, "Computer Science");
        myStudent.Introduce();
    }
}