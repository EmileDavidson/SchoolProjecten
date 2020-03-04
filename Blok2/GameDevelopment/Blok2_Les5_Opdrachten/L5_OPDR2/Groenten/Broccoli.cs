    using System;
    namespace Groenten{
    public class Broccoli : Consturctor{
        private string name;
        private string soort;
        public Broccoli(string name, string soort): base(name, soort){
            this.name = name;
            this.soort = soort;
        }
        public string GetName(){
            return name;
        }
        public string GetSoort(){
            return soort;
        }
    }
    }