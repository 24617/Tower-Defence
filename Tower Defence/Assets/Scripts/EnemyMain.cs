using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{

    public enum Enemies { Goblin, Pumpkin, Troll, Demon };
    public static int enemyHealthbar;

    public Enemies Enemy = Enemies.Pumpkin;
    
    void Awake()
    {
        if (Enemy == Enemies.Goblin)
        {
            enemyHealthbar = 25;
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Goblin");
        }
        else if (Enemy == Enemies.Pumpkin)
        {
            enemyHealthbar = 15;
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pumpkin");
        }
        else if (Enemy == Enemies.Troll)
        {
            enemyHealthbar = 50;
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Troll");
        }
        else if (Enemy == Enemies.Demon)
        {
            enemyHealthbar = 30;
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Demon");
        }
    }
}