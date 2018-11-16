using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {

    float groundNumber = 1.6f;
    public List<Vector2> waypointsUP = new List<Vector2>();
    public List<Vector2> waypointsDown = new List<Vector2>();

    public void Awake()
    {
        
        waypointsUP.Add(new Vector2((groundNumber * 4), (groundNumber * 17)));
        waypointsUP.Add(new Vector2((groundNumber * 4), (groundNumber * 8)));
        waypointsUP.Add(new Vector2((groundNumber * 8), (groundNumber * 8)));
        waypointsUP.Add(new Vector2((groundNumber * 8), (groundNumber * 14)));
        waypointsUP.Add(new Vector2((groundNumber * 14), (groundNumber * 14)));
        waypointsUP.Add(new Vector2((groundNumber * 14), (groundNumber * 7)));
        waypointsUP.Add(new Vector2((groundNumber * 18), (groundNumber * 7)));
        waypointsUP.Add(new Vector2((groundNumber * 18), (groundNumber * 7)));


        waypointsDown.Add(new Vector2((groundNumber * 4), (groundNumber * 17)));
        waypointsDown.Add(new Vector2((groundNumber * 4), (groundNumber * 8)));
        waypointsDown.Add(new Vector2((groundNumber * 6), (groundNumber * 8)));
        waypointsDown.Add(new Vector2((groundNumber * 6), (groundNumber * 5)));
        waypointsDown.Add(new Vector2((groundNumber * 15), (groundNumber * 5)));
        waypointsDown.Add(new Vector2((groundNumber * 15), (groundNumber * 7)));
        waypointsDown.Add(new Vector2((groundNumber * 18), (groundNumber * 7)));
        waypointsDown.Add(new Vector2((groundNumber * 18), (groundNumber * 7)));



    }
    public List<Vector2> GetUpperWaypoints()
    {
        return waypointsUP;
    }

    public List<Vector2> GetLowerWaypoints()
    {
        return waypointsDown;
    }
}
