using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
    private enum Enemies {Goblin, Pumpkin, Troll, Demon };
    private int EnemyHealthbar;

    void Start()
    {
        Enemies ThisEnemy;

        ThisEnemy = Enemies.Goblin;
    }

    Enemies GetEnemy (Enemies Enemy)
    {
        
        if (Enemy == Enemies.Goblin)
        {
            EnemyHealthbar = 25;
        }
        else if (Enemy == Enemies.Pumpkin)
        {
            EnemyHealthbar = 15;
        }
        else if (Enemy == Enemies.Troll)
        {
            EnemyHealthbar = 50;
        }
        else if (Enemy == Enemies.Demon)
        {
            EnemyHealthbar = 30;
        }

        return Enemy;
    }
}