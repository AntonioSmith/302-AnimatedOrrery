using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform target;

    [Range(-100, 100)] public float Xradius;
    [Range(-100, 100)] public float Yradius; // Separated radius into each axes so it's editable in Inspector
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
        offset.y = Mathf.Cos(age) * Yradius;
        offset.z = Mathf.Cos(age) * Zradius;

        transform.position = target.position + offset;
    }

}
