﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    WaveConfig waveConfig;
    List<Transform> waypoints;
    int waypointIndex = 0;

    void Start()
    {
        waypoints = waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].transform.position;
        //Debug.Log(transform.position);
    }

    void Update()
    {
        Move();
    }

    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Count - 1)
        {
            var targetPosition = waypoints[waypointIndex].transform.position;
            var movementThisFrame = waveConfig.GetMoveSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards
                (transform.position, targetPosition, movementThisFrame);

            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //private void Move()
    //{
    //    if (waypointIndex <= waypoints.Count - 1)
    //    {
    //        var targetPosition = waypoints[waypointIndex].transform.position;
    //        var movementThisFrame = moveSpeed * Time.deltaTime;

    //        transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);
    //        //Debug.Log("MOVED");
    //        //Debug.Log(transform.position + targetPosition);


    //        if (transform.position == targetPosition)
    //        {
    //            waypointIndex++;
    //            //Debug.Log("WayPoint Index Increased" + " : "  + waypointIndex);
    //            //Debug.Log(transform.position + targetPosition);
    //        }
    //        else
    //        {
    //            //if(waypointIndex == 3)
    //            //{
    //            //    Destroy(gameObject);
    //            //    Debug.Log("Deleted" + gameObject);
    //            //}
    //            Destroy(gameObject);
    //            //Debug.Log("Deleted" + " " + gameObject);
    //        }
    //    }
    //}
}
