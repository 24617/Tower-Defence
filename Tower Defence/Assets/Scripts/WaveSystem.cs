using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour {

    public enum Enemies { Goblin, Pumpkin, Troll, Demon };

    public Enemies Enemy;

    public static int enemyHealthbar;


    public GameObject singleEnemy;
    //GameObject singleEnemy;

    void Start () {
        //Instantiate(Enemy, transform.position, Quaternion.identity);
    }
	
	
	void Update () {
        SpawnEnemy();
	}

    void SpawnEnemy()
    {
        singleEnemy = Instantiate(singleEnemy, transform.position, Quaternion.identity);

        if (Enemy == Enemies.Goblin)
        {
            enemyHealthbar = 25;
            //singleEnemy.GetComponent<EnemyMain>().enemyHealthbar = singleEnemy;
            //singleEnemy.enemyHealthbar = 25;
            singleEnemy.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Goblin");
        }
        else if (Enemy == Enemies.Pumpkin)
        {
            enemyHealthbar = 15;
            singleEnemy.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pumpkin");
        }
        else if (Enemy == Enemies.Troll)
        {
            enemyHealthbar = 50;
            singleEnemy.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Troll");
        }
        else if (Enemy == Enemies.Demon)
        {
            enemyHealthbar = 30;
            singleEnemy.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Demon");
        }
    }
}
