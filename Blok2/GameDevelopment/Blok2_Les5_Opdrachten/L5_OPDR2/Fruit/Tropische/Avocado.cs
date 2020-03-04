    using System;
    namespace Fruit.Tropische{
        public class Avocado : Consturctor{
        private string name;
        private string soort;
        public Avocado(string name, string soort): base(name, soort){
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
