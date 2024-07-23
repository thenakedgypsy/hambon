using System;

public static class Player
{
    public static string PlayerName {get; set;} = "";
    public static int NeededXP {get; set;} = 100;
    public static int CurrentXP {get; set;} = 0;
    public static int CurrentHP {get; set;} = 100;
    public static int MaxHP {get; set;} = 100;
    public static int Level {get; set;} = 1;
    public static int Strength {get;set;} = 3;
    public static int Intelligence {get;set;} = 3;
    public static int Shield {get;set;} = 1;
    public static int Gold {get;set;} = 0;


public static void resetProgress()
{
    PlayerName = "";
    NeededXP = 100;
    CurrentHP = 100;
    CurrentXP = 0;
    MaxHP = 100;
    Level = 1;
}

public static int AttackRoll()
{
    Random random = new Random();
    int roll = Strength * random.Next(1,6);
    return roll;
}



}