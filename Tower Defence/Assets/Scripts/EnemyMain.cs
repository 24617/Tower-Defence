using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{

    enum Enemies { Goblin, Pumpkin, Troll, Demon };
    private string EnemyName;
    public int EnemyHealthbar;
    
    void Start()
    {
        
        Enemies myEnemy;

        myEnemy = Enemies.Goblin;
    }


    Enemies ReverseEnemy(Enemies Enemy)
    {
        
        if (Enemy == Enemies.Goblin)
        {
            EnemyHealthbar = 25;
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Goblin");
        }
        else if (Enemy == Enemies.Pumpkin)
        {
            EnemyHealthbar = 15;
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pumpkin");
        }
        else if (Enemy == Enemies.Troll)
        {
            EnemyHealthbar = 50;
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Troll");
        }
        else if (Enemy == Enemies.Demon)
        {
            EnemyHealthbar = 30;
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Demon");
        }

        return Enemy;
        
    }
}