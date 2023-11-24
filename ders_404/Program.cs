using System;

namespace ders_404
{
    class Student
    {
        public string Name { get; set; }
        public int StudentNumber { get; set; }
        public static string School  = "My School";
        public static string Address = "My School Address";

        public Student(string name, int studentnumber)
        {
            this.Name = name;
            this.StudentNumber = studentnumber;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"name: {this.Name}, number: {this.StudentNumber}");
        }

        public static void DisplaySchoolDetails()
        {
            Console.WriteLine($"School Name: {School} Adress: {Address}");
        }
    }
    
    static class HelperMethods
    {
        public static string KarakterDuzelt(string str)
        {
            return str
                        .Replace("ö","o")
                        .Replace("ü","u")
                        .Replace("ç","c")
                        .Replace(" ","-")
                        .Replace("ğ","g")
                        .ToLower();
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            // var s1 = new Student("Izzat",1);
            // var s2 = new Student("Esqin",2);
            // var s3 = new Student("Etibar",3);
            
            // Student.DisplaySchoolDetails();
            
            // s1.DisplayStudentDetails();
            // s2.DisplayStudentDetails();
            // s2.DisplayStudentDetails();

            string str = "Ölçme ve Değerlendirme";
            var result = HelperMethods.KarakterDuzelt(str);
            Console.WriteLine(result);
            
        }
    }
}
