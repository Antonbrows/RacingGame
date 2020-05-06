using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        double pos = Map(DateTime.Now.TimeOfDay.TotalMinutes, 0, 1440, 0, 360) - 90;
        gameObject.transform.eulerAngles = new Vector3(Convert.ToSingle(pos), 0, 0);
    }

    public double Map(double timeNow, double a1, double a2, double b1, double b2)
    {
        return (timeNow - a1) / (a2 - a1) * (b2 - b1) + b1;
    }


}