using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class маятник : MonoBehaviour
{
    public Vector3 pos;
    public float angle1, angle2, vol, l;
    private float t;
    private const double g = 9.81;
    // Start is called before the first frame update
    void Start()
    {
        angle1 = 10;
        t = 0;
        vol = 5;
        l = 2;
        pos = new Vector3((float)(l * Math.Cos(angle1)), 0, (float)(l * Math.Sin(angle1)));

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        angle2 = (float)(angle1 * Math.Cos(Math.Sqrt(g / l)) * t + vol * Math.Sqrt(g / l) + angle1 * Math.Sin(Math.Sqrt(g / l)) * t);
        pos = new Vector3((float)(l * Math.Cos(angle2)), 0, (float)(l * Math.Sin(angle2)));
        transform.position = pos;

    }
}
