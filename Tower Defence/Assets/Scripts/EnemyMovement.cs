using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    [SerializeField]
    Transform[] waypoints_1;

    [SerializeField]
    Transform[] waypoints_2;
    
    [SerializeField]
    Transform[] Fullwaypoint;

    float enemyMoveSpeed = 0.1f;
    int waypointIndex = 0;
    int currentWaypoint;

    void Start () {
        currentWaypoint = Random.Range(1, 3);

        if (currentWaypoint == 1) {
            Fullwaypoint = waypoints_1;
            transform.position = Fullwaypoint[waypointIndex].transform.position;
        }

        if (currentWaypoint == 2)
        {
            Fullwaypoint = waypoints_2;
            transform.position = Fullwaypoint[waypointIndex].transform.position;
        }
        waypointIndex += 1;
    }
	
	void Update () {

        Move();
        TowerReach();
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, Fullwaypoint[waypointIndex].transform.position, enemyMoveSpeed * Time.deltaTime);

        if (this.transform.position.x == Fullwaypoint[waypointIndex].transform.position.x
            && this.transform.position.y == Fullwaypoint[waypointIndex].transform.position.y)
        {
            waypointIndex += 1;
        }

        Vector3 LookAtPosition = (Fullwaypoint[waypointIndex].transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(LookAtPosition.y, LookAtPosition.x) * Mathf.Rad2Deg;
        Quaternion rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, 0, angle + 90);
        transform.rotation = rotation;
    }

    void TowerReach()
    {
        if (waypointIndex == Fullwaypoint.Length)
        {
            Destroy(this.gameObject);
        }

    }
}
