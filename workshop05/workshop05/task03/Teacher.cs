namespace task03;

public class Teacher : SalaryInfos
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    // This method cannot be overridden
    public sealed override void SalaryInfo()
    {
        Console.WriteLine("This is the salary information of the teacher.");
        Console.WriteLine("Cannot be overridden.");
    }
}