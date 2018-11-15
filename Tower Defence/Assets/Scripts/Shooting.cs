using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    TargetLookAt getEnemy;
    
    public GameObject projectile;
    public GameObject closestEnemy;
    public int bulletDamage;


    private float Shoottimer = 2f;

    public bool canShoot = false;

	void Update ()
    {

        Shoottimer -= Time.deltaTime;
        if (Shoottimer <=0) {

            if (canShoot == true)
            {
                getEnemy = GetComponent<TargetLookAt>();
                closestEnemy = TargetLookAt.getEnemyGameobject;
                ShootBullet();
                Shoottimer = 2f;
            }
        }
    }



    public void ShootBullet()
    {
        var shoot = Instantiate(projectile, transform.position, Quaternion.identity);
        shoot.transform.rotation = transform.rotation;
        shoot.GetComponent<Bullet>().MyEnemy = closestEnemy;
        shoot.GetComponent<Bullet>().bulletVelocity = 10f;
        shoot.GetComponent<Bullet>().bulletDamage = bulletDamage;



    }


}