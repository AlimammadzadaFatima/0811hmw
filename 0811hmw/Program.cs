using System;

namespace _0811hmw
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Fullname = "Fatime Elimemmedzade",
            };
            Student student1 = new Student
            {
                Fullname = "Husniyye Zeynalli",
            };
            Student student2 = new Student
            {
                Fullname = "Nermin Eliyeva",
            };
            Student student3 = new Student
            {
                Fullname = "Aydan Heybetova",
            };
            Student student4 = new Student
            {
                Fullname = "Nigar Shixeliyeva",
            };
            Student student5 = new Student
            {
                Fullname = "Leyla Quliyeva",
            };
            Student student6 = new Student
            {
                Fullname = "Refiqe Israfilova",
            };
            Student student7 = new Student
            {
                Fullname = "Xanim Hesenova",
            };
            Student student8 = new Student
            {
                Fullname = "Natavan Ramazanli",
            };
            Student student9 = new Student
            {
                Fullname = "Humay Mirzeyeva",
            };
            Group group = new Group(GroupType.Programming);
            Group group1 = new Group(GroupType.System);
            Group group2 = new Group(GroupType.Design);
            Group group3 = new Group(GroupType.Programming);
            
            group.AddStudents(student);
            group.AddStudents(student1);
            group.AddStudents(student2);
            group1.AddStudents(student3);
            group1.AddStudents(student4);
            group2.AddStudents(student5);
            group2.AddStudents(student6);
            group2.AddStudents(student7);
            group3.AddStudents(student8);
            group3.AddStudents(student9);
            Group[] groups = { group1, group, group2, group3 };
           
            string type = group.Type == GroupType.Programming ? "Programming" : group.Type == GroupType.Design ? "Desing" : "System";
            Console.WriteLine("---------------");
            Console.WriteLine($"Grup No: {group.GroupNo}");
            Console.WriteLine("Telebeler");
            Console.WriteLine("---------------");
            foreach (var item in group.students)
            {
                Console.WriteLine($"Fullname: {item.Fullname} - No: {item.No}  ");
            }
            string type1 = group1.Type == GroupType.Programming ? "Programming" : group1.Type == GroupType.Design ? "Desing" : "System";
            Console.WriteLine("---------------"); 
            Console.WriteLine($"Grup No: {group1.GroupNo}");
            Console.WriteLine("Telebeler");
            Console.WriteLine("---------------");
            foreach (var item in group1.students)
            {
                Console.WriteLine($"Fullname: {item.Fullname} - No: {item.No}  ");
            }
            string type2 = group2.Type == GroupType.Programming ? "Programming" : group2.Type == GroupType.Design ? "Desing" : "System";
            Console.WriteLine("---------------"); 
            Console.WriteLine($"Grup No: {group2.GroupNo}");
            Console.WriteLine("Telebeler");
            Console.WriteLine("---------------");
            foreach (var item in group2.students)
            { 
                Console.WriteLine($"Fullname: {item.Fullname} - No: {item.No}  ");
            }
            string type3 = group2.Type == GroupType.Programming ? "Programming" : group3.Type == GroupType.Design ? "Desing" : "System";
            Console.WriteLine("---------------"); 
            Console.WriteLine($"Grup No: {group3.GroupNo}");
            Console.WriteLine("Telebeler");
            Console.WriteLine("---------------");
            foreach (var item in group3.students)
            {
                Console.WriteLine($"Fullname: {item.Fullname} - No: {item.No}  ");
            }
            foreach (var item in groups)
            {
                item.FindStudentByNo();
            }
           // Find StudentByNo tam duzelde bilmedim studentin hansi qrupda oldugunu tapana qeder no daxil etmeyimizi isteyir

        }
    }
}
