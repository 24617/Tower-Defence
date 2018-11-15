using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float bulletVelocity = 10f;

    public GameObject MyEnemy;
    EnemyHealthBar Healthreduce;
    public int bulletDamage;

	void Update () {

        if (MyEnemy.gameObject == null)
        {
            Destroy(this.gameObject);
        }

        if (MyEnemy.gameObject != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, MyEnemy.transform.position, bulletVelocity * Time.deltaTime);

            Vector3 vectorToTarget = MyEnemy.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 360);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == MyEnemy)
        {
            MyEnemy.GetComponent<EnemyHealthBar>().EnemyHealth -= bulletDamage;
            Destroy(this.gameObject);
        }
    }
}
