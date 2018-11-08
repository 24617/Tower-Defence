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

        Vector3 vectorToTarget = (Vector3)fullwaypoint[waypointIndex] - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle + 90, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 360);

    }

    void TowerReach()
    {
        if (waypointIndex == fullwaypoint.Count)
        {
            Destroy(this.gameObject);
        }

    }
}
