using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMaps : MonoBehaviour {

    Vector3 mousePos;
    GameObject cursor;

    public Transform[] AllWaypoints;
    float GN = 1.6f;



    int[ , ] myGrid = 
         {
           {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
           {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
           {3,3,3,3,3,3,3,3,3,3,3,4,4,4,3,3,3,3,3,3},
           {3,3,3,3,3,3,3,3,3,1,1,1,4,4,4,1,3,3,3,3},
           {3,3,3,3,3,1,1,1,1,1,1,1,1,1,1,1,1,1,1,3},
           {3,4,4,4,1,1,0,0,0,0,0,0,0,0,0,0,1,1,1,1},
           {4,4,4,1,1,1,0,1,1,1,1,1,1,1,1,0,1,1,1,1},
           {4,4,1,1,1,1,0,1,1,1,1,3,1,1,0,0,0,0,0,5},
           {4,1,1,1,0,0,0,0,0,1,1,3,3,1,0,1,1,1,1,1},
           {1,1,1,1,0,1,1,1,0,1,1,3,3,1,0,1,1,1,1,1},
           {3,1,1,1,0,1,1,1,0,1,3,3,3,1,0,1,1,1,1,1},
           {3,1,1,1,0,1,1,1,0,1,3,3,1,1,0,1,1,1,1,3},
           {3,3,1,1,0,1,3,1,0,1,1,3,1,1,0,1,1,1,4,3},
           {3,3,1,1,0,1,3,1,0,1,1,1,1,1,0,1,1,4,4,3},
           {3,3,3,1,0,1,3,3,0,0,0,0,0,0,0,1,4,4,3,3},
           {3,3,3,3,0,3,3,3,3,3,1,1,1,1,1,1,4,4,3,3},
           {3,3,3,3,0,3,3,4,4,3,3,3,3,1,1,4,4,3,3,3},
           {3,3,3,3,0,3,4,4,4,4,4,3,3,3,4,4,3,3,3,3}
          };



    void Start()
    {

        for (var y = 0; y < 18; y++)
        {
            for (var x = 0; x < 20; x++)
            {
                
                switch (myGrid[y,x])
                {
                    case 0:
                        GameObject Path = GameObject.Instantiate(Resources.Load<GameObject>("Path"), new Vector2((GN * x), (GN  * y)),Quaternion.identity) as GameObject;
                        Path.layer = LayerMask.NameToLayer("Background");
                        Path.transform.parent = GameObject.Find("Background").transform;
                        break;
                    case 1:
                        GameObject Grass = GameObject.Instantiate(Resources.Load<GameObject>("Grass"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                        Grass.layer = LayerMask.NameToLayer("Background");
                        Grass.transform.parent = GameObject.Find("Background").transform;
                        break;
                    case 2:
                        GameObject GreyMenu = GameObject.Instantiate(Resources.Load<GameObject>("GreyMenu"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                        GreyMenu.layer = LayerMask.NameToLayer("Background");
                        GreyMenu.transform.parent = GameObject.Find("Background").transform;
                        break;
                    case 3:
                        GameObject Wood = GameObject.Instantiate(Resources.Load<GameObject>("Wood"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                        Wood.layer = LayerMask.NameToLayer("Background");
                        Wood.transform.parent = GameObject.Find("Background").transform;
                        break;
                    case 4:
                        GameObject Water = GameObject.Instantiate(Resources.Load<GameObject>("Water"), new Vector2((GN * x), (GN * y)), Quaternion.identity) as GameObject;
                        Water.layer = LayerMask.NameToLayer("Background");
                        Water.transform.parent = GameObject.Find("Background").transform;
                        break;
                    case 5:
                        GameObject Castle = GameObject.Instantiate(Resources.Load<GameObject>("Castle"), new Vector3((GN * x), (GN * y),-0.1f), Quaternion.identity) as GameObject;
                        Castle.name = "Castle";
                        Castle.layer = LayerMask.NameToLayer("Background");
                        Castle.transform.parent = GameObject.Find("Background").transform;
                        break;

                }
            }
        }

        GameObject ArcherTower = GameObject.Instantiate(Resources.Load<GameObject>("ArcherSpawner"), new Vector3((GN * 1), (GN * 1), -0.1f), Quaternion.identity) as GameObject;
        ArcherTower.name = "ArcherSpawner";
        GameObject MageTower = GameObject.Instantiate(Resources.Load<GameObject>("MageSpawner"), new Vector3((GN * 3), (GN * 1), -0.1f), Quaternion.identity) as GameObject;
        MageTower.name = "MageSpawner";
        GameObject IceTower = GameObject.Instantiate(Resources.Load<GameObject>("IceSpawner"), new Vector3((GN * 5), (GN * 1), -0.1f), Quaternion.identity) as GameObject;
        IceTower.name = "IceSpawner";
        GameObject BombTower = GameObject.Instantiate(Resources.Load<GameObject>("BombSpawner"), new Vector3((GN * 7), (GN * 1), -0.1f), Quaternion.identity) as GameObject;
        BombTower.name = "BombSpawner";

        GameObject castleHealth = GameObject.Instantiate(Resources.Load<GameObject>("CastleHealth"), new Vector3((GN * 0), (GN * 0), -0.1f), Quaternion.identity) as GameObject;
        castleHealth.transform.parent = GameObject.Find("Castle").transform;

        GameObject Enemyspawn = GameObject.Instantiate(Resources.Load<GameObject>("SpawnCave"), new Vector3((GN * 4), (GN * 18), -0.1f), Quaternion.identity) as GameObject;

        cursor = GameObject.Instantiate(Resources.Load<GameObject>("Cursor"), new Vector3((mousePos.x), (mousePos.y), -0.3f), Quaternion.identity) as GameObject;

    }

    private void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        
        cursor.transform.position = new Vector3(GN * Mathf.Round(mousePos.x / GN), GN * Mathf.Round(mousePos.y / GN), -0.01f);
    }



}
