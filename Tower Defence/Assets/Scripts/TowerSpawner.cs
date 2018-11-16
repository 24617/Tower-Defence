using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    private bool canMakeTurret = true;
    GameObject towerHold;
    float snapvalue = 1.6f;

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (Input.GetMouseButtonDown(0))
        {

            if (canMakeTurret == false)
            {
                if (towerHold.gameObject.name == "ArcherMover")
                {
                    GameObject Turret = GameObject.Instantiate(Resources.Load<GameObject>("Archer Tower"), new Vector3(towerHold.transform.position.x,towerHold.transform.position.y, -0.1f), Quaternion.identity) as GameObject;
                    Turret.GetComponent<Shooting>().bulletDamage = 5;

                }
                if (towerHold.gameObject.name == "MageMover")
                {
                    GameObject Turret = GameObject.Instantiate(Resources.Load<GameObject>("Mage Tower"), new Vector3(towerHold.transform.position.x, towerHold.transform.position.y, -0.1f), Quaternion.identity) as GameObject;
                    Turret.GetComponent<Shooting>().bulletDamage = 8;
                }
                if (towerHold.gameObject.name == "IceMover")
                {
                    GameObject Turret = GameObject.Instantiate(Resources.Load<GameObject>("Ice Tower"), new Vector3(towerHold.transform.position.x, towerHold.transform.position.y, -0.1f), Quaternion.identity) as GameObject;
                    Turret.GetComponent<Shooting>().bulletDamage = 2;
                }
                if (towerHold.gameObject.name == "BombMover")
                {
                    GameObject Turret = GameObject.Instantiate(Resources.Load<GameObject>("Bomb Tower"), new Vector3(towerHold.transform.position.x, towerHold.transform.position.y, -0.1f), Quaternion.identity) as GameObject;
                    Turret.GetComponent<Shooting>().bulletDamage = 3;
                }
                Destroy(towerHold.gameObject);
                canMakeTurret = true;

            }

            if (canMakeTurret == true)
                {

                if (hit.collider.gameObject.name == "ArcherSpawner")
                {
                    towerHold = GameObject.Instantiate(Resources.Load<GameObject>("ArcherSpawner"), new Vector3((mousePos.x), (mousePos.y), -0.3f), Quaternion.identity) as GameObject;
                    towerHold.name = "ArcherMover";
                    canMakeTurret = false;


                }
                else if (hit.collider.gameObject.name == "MageSpawner")
                {
                    towerHold = GameObject.Instantiate(Resources.Load<GameObject>("MageSpawner"), new Vector3((mousePos.x), (mousePos.y), -0.3f), Quaternion.identity) as GameObject;
                    towerHold.name = "MageMover";
                    canMakeTurret = false;
                }
                else if (hit.collider.gameObject.name == "IceSpawner")
                {
                    towerHold = GameObject.Instantiate(Resources.Load<GameObject>("IceSpawner"), new Vector3((mousePos.x), (mousePos.y), -0.3f), Quaternion.identity) as GameObject;
                    towerHold.name = "IceMover";
                    canMakeTurret = false;
                }
                else if (hit.collider.gameObject.name == "BombSpawner")
                {
                    towerHold = GameObject.Instantiate(Resources.Load<GameObject>("BombSpawner"), new Vector3((mousePos.x), (mousePos.y), -0.3f), Quaternion.identity) as GameObject;
                    towerHold.name = "BombMover";
                    canMakeTurret = false;
                }
                
                }

            

        }

        if (canMakeTurret == false)
        {
            towerHold.transform.parent = GameObject.Find("Grid").transform;
            towerHold.transform.position = new Vector3(snapvalue * Mathf.Round(mousePos.x / snapvalue), snapvalue * Mathf.Round(mousePos.y / snapvalue), -0.3f);
        }


    }
    
}
