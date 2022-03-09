using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Осциллятор : MonoBehaviour
{
    public Vector3 pos ;
    private float vol, angle1, angle2, t, x, l, pos_x, pos_y, phase;
    private const double G = 9.8;
    // Start is called before the first frame update
    void Start()
    {
        l = 4;
        vol = 5;
        angle1 = 10;
        angle2 = 15;
        t = 0;
        phase = 3;
        pos = new Vector3(0, 0, 0);

    }
    

    // Update is called once per frame
    void Update()
    { 
        t += Time.deltaTime;
        pos = new Vector3((float)((vol / angle1) * Math.Cos(angle1 * t + phase)) , 0 ,(float)((vol / angle2) * Math.Sin(angle2 * t + phase)));
        transform.position = pos;
    }
}
