    using System;
    namespace Zoetigheid{
    public class Snoep : Consturctor{
        
        private string name;
        private string soort;
        public Snoep(string name, string soort): base(name, soort){
            this.name = name;
            this.soort = soort;
        }
        public string GetName(){
            return name;
        }
        public string GetSoort(){
            return soort;
        }
    }}
