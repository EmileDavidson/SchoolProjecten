    using System;
    namespace Fruit{
        public class Appel : Consturctor{
        private string name;
        private string soort;
        public Appel(string name, string soort): base(name, soort){
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