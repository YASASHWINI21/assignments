namespace MVC.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public bool IsHobbies { get; set; }
        public Courses StudentCourses { get; set; }
        public Skills SudentSkills { get; set; }

    }

    public enum Courses
    {
        Csharp,
        DOTNetprogramming,
        Html,
        CSS,
        ADODOTNETprogramming,
        ASPDOTNETprogramming

    }
    public enum Skills
    {
        PythonPrograamming,
        JavaProgramming,
        CProgramming,
        DBMS
    }
}