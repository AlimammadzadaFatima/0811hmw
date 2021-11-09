using System;
using System.Collections.Generic;
using System.Text;

namespace _0811hmw
{
    enum GroupType
    {
        Programming,
        Design,
        System
    }
    class Group 
    { public Group(GroupType Type)
        {
            count +=1;
            if (Type == GroupType.Programming)
            { GroupNo = "P" + count; }
            else if (Type == GroupType.Design)
            { GroupNo = "D" + count; }
            else if (Type==GroupType.System)
            { GroupNo = "S" + count; }
        }
        
       public Student[] students = new Student[0];
        public Group[] groups = new Group[0];
        public GroupType Type;
        public string GroupNo;
        public static int count=100;
        public void AddStudents(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        public void  FindStudentByNo()
        {
            int no;
            string nostr;
            do
            {
                Console.WriteLine("Axtardiginiz telebenin no deyerini daxil edin");
                nostr = Console.ReadLine();
            } while (!int.TryParse(nostr, out no));
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].No == no)
                {
                    Console.WriteLine($"Fullname: {students[i].Fullname} - No: {students[i].No} ");
                }
            }



        }
        public void GetInfo(Student student)
        {
            
            Console.WriteLine($"Fullname: {student.Fullname} - No: {student.No} ");
        }

    }
}
