using System;

namespace L3_OPDR2
{
    public class Monster
    {
        private string name;
        private int HP;
        private Boolean dead = false;

        //sonstuctor (met dank aan jesse)
        public Monster(int someHP, string aName)
        {
            HP = someHP;
            name = aName;
        }
        //name
        //die returned de name
        public string GetName()
        {
            return name;
        }
        //HP
        //die returned het HP die er momenteel is
        public int GetHP()
        {
            return HP;
        }
        //pakt de int die word mee gegeven. in program in die plaatst hij in de Variable HP en die word gepakt door de getter
        public void SetHP(int nieuwHP)
        {
            this.HP = nieuwHP;
        }
        //dead
    }
}