    using System;
    namespace Fruit.Tropische{
        public class Ananas : Consturctor{
        private string name;
        private string soort;
        public Ananas(string name, string soort): base(name, soort){
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
