using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {

    float GN = 0.16f;
    public List<Vector2> waypointsUP = new List<Vector2>();
    public List<Vector2> waypointsDown = new List<Vector2>();

    public void Awake()
    {
        
        waypointsUP.Add(new Vector2((GN * 4), (GN * 17)));
        waypointsUP.Add(new Vector2((GN * 4), (GN * 8)));
        waypointsUP.Add(new Vector2((GN * 8), (GN * 8)));
        waypointsUP.Add(new Vector2((GN * 8), (GN * 14)));
        waypointsUP.Add(new Vector2((GN * 14), (GN * 14)));
        waypointsUP.Add(new Vector2((GN * 14), (GN * 7)));
        waypointsUP.Add(new Vector2((GN * 18), (GN * 7)));

        waypointsDown.Add(new Vector2((GN * 4), (GN * 17)));
        waypointsDown.Add(new Vector2((GN * 4), (GN * 8)));
        waypointsDown.Add(new Vector2((GN * 6), (GN * 8)));
        waypointsDown.Add(new Vector2((GN * 6), (GN * 5)));
        waypointsDown.Add(new Vector2((GN * 15), (GN * 5)));
        waypointsDown.Add(new Vector2((GN * 15), (GN * 7)));
        waypointsDown.Add(new Vector2((GN * 18), (GN * 7)));



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
