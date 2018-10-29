using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{

   // Sprite[] sprites = Resources.LoadAll<Sprite>(pathToTexture);

    private enum Enemies { Goblin, Pumpkin, Troll, Demon };
    private string EnemyName;
    private int EnemyHealthbar;
    

    void Start()
    {
       // sprites = Resources.LoadAll<Sprite>(Goblin, Pumpkin, Troll, Demon);

        Enemies ThisEnemy;

        ThisEnemy = Enemies.Goblin;
    }

    Enemies GetEnemy(Enemies Enemy)
    {

        if (Enemy == Enemies.Goblin)
        {
            EnemyHealthbar = 25;
            //this.GetComponent<SpriteRenderer>().sprite = EnemyArt.Goblin;
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