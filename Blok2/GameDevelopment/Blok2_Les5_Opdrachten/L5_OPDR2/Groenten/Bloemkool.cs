    using System;
    namespace Groenten{
    public class Bloemkool : Consturctor{
        private string name;
        private string soort;
        public Bloemkool(string name, string soort): base(name, soort){
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