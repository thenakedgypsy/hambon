using System;
public static class EnemyGenerator
{
    public static List<string> names = new List<string>{
    "Goblin",
     "Boar",
     "Duck",
     "Toaster",
     "Fish",
     "Troll",
     "Cyclops",
     "Alice",
     "Poop Monster",
     "Oversized Cabbage"
    };

    public static Enemy Generate()
    {
        
        Random random = new Random();
        int level = 1 * random.Next(1,9 + Player.Level);
        double health = random.Next(1,level*5) * level;
        int nameSeed = random.Next(0,names.Count);
        int toughness = random.Next(-3,3) + level;
        if(toughness < 1)
        {
            toughness = 1;
        }
        Enemy enemy = new Enemy(names[nameSeed],(int)health,level,toughness);
        return enemy;
    }



}