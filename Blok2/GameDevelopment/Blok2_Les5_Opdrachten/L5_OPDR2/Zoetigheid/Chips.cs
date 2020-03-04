    using System;
    namespace Zoetigheid{
    public class Chips : Consturctor{
        private string name;
        private string soort;
        public Chips(string name, string soort): base(name, soort){
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