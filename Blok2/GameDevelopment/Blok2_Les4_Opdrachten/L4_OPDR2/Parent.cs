using System;

namespace L4_OPDR2
{
    class Parent : Person
    {
        private string Eigenschap;
        private string gender;
        public Parent(string name, string gender) : base(name)
        {
            this.gender = gender;
            Console.WriteLine("Gender is: " + gender);
            
        }

        public void SetEigenschap(string a)
        {
            Eigenschap = a;
        }
        public string GetEigenschap(){return Eigenschap;}
    }
}
