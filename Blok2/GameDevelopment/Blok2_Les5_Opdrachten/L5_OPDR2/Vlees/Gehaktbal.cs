    using System;
    namespace Vlees{
    public class Gehaktbal : Consturctor{
        private string name;
        private string soort;
        public Gehaktbal(string name, string soort): base(name, soort){
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