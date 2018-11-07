using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemyMovement : MonoBehaviour {

    WayPoints wayPoints;

    List<Vector2> fullwaypoint;

    float enemyMoveSpeed = 0.2f;
    int waypointIndex = 0;
    int currentWaypoint;

    void Start () {
        currentWaypoint = Random.Range(1, 3);
        wayPoints = GameObject.Find("WayPoints").GetComponent<WayPoints>();

        if (currentWaypoint == 1) {
            fullwaypoint = wayPoints.GetUpperWaypoints();
            transform.position = fullwaypoint[0];
        }

        if (currentWaypoint == 2)
        {
            fullwaypoint = wayPoints.GetLowerWaypoints();
            transform.position = fullwaypoint[0];
        }
        waypointIndex =+ 1;
        
    }
	
	void Update () {
       Move();
       TowerReach();
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, fullwaypoint[waypointIndex], enemyMoveSpeed * Time.deltaTime);
        
        if (transform.position.x == fullwaypoint[waypointIndex].x
            && transform.position.y == fullwaypoint[waypointIndex].y)
        {
            waypointIndex += 1;
        }
        
        Vector2 LookAtPosition = (fullwaypoint[waypointIndex] =- transform.position).normalized;
        float angle = Mathf.Atan2(LookAtPosition.y, LookAtPosition.x) * Mathf.Rad2Deg;
        Quaternion rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, 0, angle + 90);
        transform.rotation = rotation;
        
    }

    void TowerReach()
    {
        if (waypointIndex == fullwaypoint.Count)
        {
            Destroy(this.gameObject);
        }

    }
}
