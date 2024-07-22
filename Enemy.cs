public class Enemy
{
    public string? EnemyName {get; set;}
    public int CurrentHP {get; set;}
    public int MaxHP {get; set;}
    public int Level {get; set;}

    public Enemy(string name, int hp, int level)
    {
        EnemyName = name;
        CurrentHP = hp;
        MaxHP = hp;
        Level = level;
    }   

    






}