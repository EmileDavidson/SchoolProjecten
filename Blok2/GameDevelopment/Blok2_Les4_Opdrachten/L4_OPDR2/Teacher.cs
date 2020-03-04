using System;

namespace L4_OPDR2
{
    
    public class Teacher : Person
    {
        private string course;
        public Teacher(string name, string course):base(name){
            this.course = course;
            Console.WriteLine("you teach " + course + "\n");
        }

        public void SetCourse(string c){
            
            course = c;
        }
    }
}