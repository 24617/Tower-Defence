using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour {

    public enum Enemies { Goblin, Pumpkin, Troll, Demon };
    public Enemies Enemy;

    public static int enemyHealthbar;
    public GameObject singleEnemy;
    bool startTimer = false;
    float timer;

    public void Start()
    {
        StartCoroutine(SpawnEnemy(10,3, 1, Enemies.Goblin));
        StartCoroutine(SpawnEnemy(15,1, 3, Enemies.Pumpkin));
        StartCoroutine(SpawnEnemy(20,4, 6, Enemies.Demon));
        StartCoroutine(SpawnEnemy(25,1, 1, Enemies.Troll));
        StartCoroutine(SpawnEnemy(30,2, 1, Enemies.Troll));
        StartCoroutine(SpawnEnemy(35,10, 2, Enemies.Goblin));
        StartCoroutine(SpawnEnemy(40,5, 3, Enemies.Goblin));
    }

    IEnumerator SpawnEnemy(float Timer,float Howmuch, float TimeBetween, Enemies Enemy)
    {
        yield return new WaitForSeconds(Timer);

        for (int i = 0; i < Howmuch; i++)
        {
                
                singleEnemy = Instantiate(singleEnemy, transform.position, Quaternion.identity);

                if (Enemy == Enemies.Goblin)
                {
                    singleEnemy.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Goblin");
                    singleEnemy.GetComponent<EnemyHealthBar>().fullHealthBar = 25;
                    singleEnemy.GetComponent<EnemyMovement>().enemyMoveSpeed = 1.5f;
                    singleEnemy.name = "Goblin";
            }
                else if (Enemy == Enemies.Pumpkin)
                {
                    singleEnemy.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pumpkin");
                    singleEnemy.GetComponent<EnemyHealthBar>().fullHealthBar = 15;
                    singleEnemy.GetComponent<EnemyMovement>().enemyMoveSpeed = 2f;
                    singleEnemy.name = "Pumpkin";
            }
                else if (Enemy == Enemies.Troll)
                {
                    singleEnemy.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Troll");
                    singleEnemy.GetComponent<EnemyHealthBar>().fullHealthBar = 50;
                    singleEnemy.GetComponent<EnemyMovement>().enemyMoveSpeed = 1f;
                    singleEnemy.name = "Troll";
            }
                else if (Enemy == Enemies.Demon)
                {
                    singleEnemy.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Demon");
                    singleEnemy.GetComponent<EnemyHealthBar>().fullHealthBar = 30;
                    singleEnemy.GetComponent<EnemyMovement>().enemyMoveSpeed = 1.5f;
                    singleEnemy.name = "Demon";
            }

            
            yield return new WaitForSeconds(TimeBetween);
        }


     
    }
}
