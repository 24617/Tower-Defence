using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMaps : MonoBehaviour {

    /*
      Path = 0;
      Grass = 1;
      Wood = 3;
      Water = 4;
      Castle = 5;

        gebruik tiles voor de grid roep het aan en dan moet je ze plaatsen met een switch
        de castle is dan op 1 terug dus dan moet je de castle verplaatsen als hij word aangeroepen
        
    */

    public Transform[] AllWaypoints;
    public GameObject EnemySpawn;
    float GN = 0.16f;



    int[,] myGrid = 
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
           {3,3,1,1,0,1,1,1,0,1,1,3,1,1,0,1,1,1,4,3},
           {3,3,1,1,0,1,1,1,0,1,1,1,1,1,0,1,1,4,4,3},
           {3,3,3,1,0,1,1,1,0,0,0,0,0,0,0,1,4,4,3,3},
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
                        Castle.layer = LayerMask.NameToLayer("Background");
                        Castle.transform.parent = GameObject.Find("Background").transform;
                        break;

                }
            }
        }

        AllWaypoints[0].transform.position = new Vector3((GN * 4), (GN * 17), -0.1f);
        AllWaypoints[1].transform.position = new Vector3((GN * 4), (GN * 8), -0.1f);
        AllWaypoints[2].transform.position = new Vector3((GN * 8), (GN * 8), -0.1f);
        AllWaypoints[3].transform.position = new Vector3((GN * 8), (GN * 14), -0.1f);
        AllWaypoints[4].transform.position = new Vector3((GN * 14), (GN * 14), -0.1f);
        AllWaypoints[5].transform.position = new Vector3((GN * 14), (GN * 7), -0.1f);
        AllWaypoints[6].transform.position = new Vector3((GN * 6), (GN * 8), -0.1f);
        AllWaypoints[7].transform.position = new Vector3((GN * 6), (GN * 5), -0.1f);
        AllWaypoints[8].transform.position = new Vector3((GN * 15), (GN * 5), -0.1f);
        AllWaypoints[9].transform.position = new Vector3((GN * 15), (GN * 7), -0.1f);
        AllWaypoints[10].transform.position = new Vector3((GN * 18), (GN * 7), -0.1f);

        GameObject ArcherTower = GameObject.Instantiate(Resources.Load<GameObject>("Archer Tower"), new Vector3((GN * 1), (GN * 1), -0.1f), Quaternion.identity) as GameObject;
        GameObject MageTower = GameObject.Instantiate(Resources.Load<GameObject>("Mage Tower"), new Vector3((GN * 3), (GN * 1), -0.1f), Quaternion.identity) as GameObject;
        GameObject IceTower = GameObject.Instantiate(Resources.Load<GameObject>("Ice Tower"), new Vector3((GN * 5), (GN * 1), -0.1f), Quaternion.identity) as GameObject;
        GameObject BombTower = GameObject.Instantiate(Resources.Load<GameObject>("Bomb Tower"), new Vector3((GN * 7), (GN * 1), -0.1f), Quaternion.identity) as GameObject;

        EnemySpawn.transform.position = new Vector3((GN * 4), (GN * 18), -0.1f);

    }

    

    void Update () {
		
	}
}
