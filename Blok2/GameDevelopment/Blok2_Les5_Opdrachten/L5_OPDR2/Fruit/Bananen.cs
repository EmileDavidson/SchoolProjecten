    using System;
    namespace Fruit{
    public class Bananen : Consturctor{
        private string name;
        private string soort;
        public Bananen(string name, string soort): base(name, soort){
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