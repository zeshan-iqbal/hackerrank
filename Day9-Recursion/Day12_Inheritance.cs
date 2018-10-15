using System;
using System.Linq;
//https://www.hackerrank.com/challenges/30-inheritance/problem?h_r=next-challenge&h_v=zen
class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;    

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    public Student(string firstName, string lastName, int id, int[] scores): base(firstName, lastName, id)
    {
        testScores = scores;
    }

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    public char Calculate()
    {
        double averageScore = testScores.Average();
        char grade;
        if (averageScore >= 90)
            grade = 'O';
        else if (averageScore >= 80)
            grade = 'E';
        else if (averageScore >= 70)
            grade = 'A';
        else if (averageScore >= 55)
            grade = 'P';
        else if (averageScore >= 40)
            grade = 'D';
        else
            grade = 'T';
        return grade;
    }
}

class Inheritence
{
    static void InheritenceTest()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}