using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public string population;
    public Transform target;

    [Range(-10, 10)] public float revolutionSpeed = 1; // Allows a range of speed for the planets between -10 and 10

    [Range(-100, 100)] public float Xradius;
    //[Range(-100, 100)] public float Yradius; // Separated radius into each axes so it's editable in Inspector
    [Range(-100, 100)] public float Zradius;
    public float age;

    void Update()
    {
        RevolveAround();
    }

    public void RevolveAround()
    {
        age += Time.deltaTime;

        Vector3 offset = new Vector3();
        offset.x = Mathf.Sin(age) * Xradius;
        //offset.y = Mathf.Sin(age) * Yradius;
        offset.z = Mathf.Cos(age) * Zradius;

        transform.position = target.position + offset;
    }
}
