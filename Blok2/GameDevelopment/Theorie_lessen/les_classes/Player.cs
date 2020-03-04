using System;
public class Player
{

    public string name = "Emile";
    public int health = 10;
    public int EXP = 0;



    public Player(string name){
        this.name = name;
    }

    //normale functie met een parameter
    public void ChangeName(string NewName)
    {
        Console.WriteLine("old name " + name);
        name = NewName;
        Console.WriteLine("new name " + name);
    }
    // maak een functie die iets terug geeft
    public int HP(int health)
    {
        Console.WriteLine("old hp " + health);
        int HP = 30;
        health = HP;
        Console.WriteLine("new hp " + health);
        return health;
    }
    public string[] shoot(int amout){
        string[] result = new string[amout];
        for(int i = 0; i < amout; i++){
            result[i] = (name + "shoot " + i + " times");
        }
        return result;
    }
    public int experience(int XP){
        Console.WriteLine("OLD EXP " + EXP);
        EXP += XP;
        Console.WriteLine("NEW EXP " + EXP);
        return EXP;
    }
}