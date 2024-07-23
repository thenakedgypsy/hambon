using System;
public class Enemy
{
    public string? EnemyName {get; set;}
    public int CurrentHP {get; set;}
    public int MaxHP {get; set;}
    public int Level {get; set;}
    public int Toughness {get;set;}
    public int Resist {get;set;}

    public Enemy(string name, int hp, int level, int toughness)
    {
        EnemyName = name;
        CurrentHP = hp;
        MaxHP = hp;
        Level = level;
        Toughness= toughness;
        
    }   

    public int AttackRoll()
    {
        Random random = new Random();
        int attackRoll = random.Next(0,10 + Level);
        return attackRoll;
    }


    






}