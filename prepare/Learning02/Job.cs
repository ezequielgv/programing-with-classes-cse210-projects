public class Job {
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;
    public void DisplayJobDetails() {
        Console.WriteLine($"* Company:{_company}.");
        Console.WriteLine($"* Position: {_jobTitle}.");
        Console.WriteLine($"* Start/finish year: {_startYear} - {_endYear}");
        Console.WriteLine("----------------------------");
    }

}