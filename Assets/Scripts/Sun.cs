using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DayColors
{
    public Color skyColor;
    public Color equatorColor;
    public Color horizonColor;
}


public class Sun : MonoBehaviour
{

    public float dayCycle = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, dayCycle * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }
}
