using System;

namespace L2_OPDR2
{
    class Parent : Person
    {
        private string gender;
        public Parent(string name, string gender):base(name){
        this.gender = gender;
        Console.WriteLine("Gender is: " + gender +"\n");
        }
    }
    }
