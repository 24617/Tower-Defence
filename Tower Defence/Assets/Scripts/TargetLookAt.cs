using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLookAt : MonoBehaviour {

    Vector2 direction;
    Shooting shoot;

    private bool Looking = false;
    public GameObject cannon;
    public static GameObject getEnemyGameobject;
    public Vector3 getEnemyVector;
    public bool foundEnemy = false;


    private void Start()
    {
        shoot = gameObject.GetComponent<Shooting>();
    }

    void Update () {
        
        if (getEnemyGameobject == null)
        {
                Looking = false;
                shoot.canShoot = false;
                foundEnemy = false;
        }


        if (Looking == true)
        {
            
            Vector3 myTarget = getEnemyVector - transform.position;
            float angle = Mathf.Atan2(myTarget.y, myTarget.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle -45, Vector3.forward);
            cannon.transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 360);
        }

     
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (foundEnemy == false)
        {
            if (collision.tag == "Enemy")
            {
                getEnemyGameobject = collision.gameObject;

                Looking = true;
                shoot.canShoot = true;
                foundEnemy = true;

            }
        }

        if (foundEnemy == true && getEnemyGameobject != null)
        {
            getEnemyVector = new Vector3(getEnemyGameobject.transform.gameObject.transform.position.x,
                                   getEnemyGameobject.transform.gameObject.transform.position.y,
                                   getEnemyGameobject.transform.gameObject.transform.position.z
                                           );
        }


    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            if (collision.gameObject == getEnemyGameobject)
            {


                Looking = false;
                shoot.canShoot = false;
                foundEnemy = false;
            }
        }
    }
}
