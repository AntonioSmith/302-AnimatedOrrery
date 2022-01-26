using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarBody : MonoBehaviour
{
    public Color myColor;
    public int xRotationSpeed;
    public int yRotationSpeed;
    public int zRotationSpeed;
    public string Name;

    private MeshRenderer mesh;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = myColor;
    }

    void Update()
    {
        transform.Rotate(xRotationSpeed * Time.deltaTime, yRotationSpeed * Time.deltaTime, zRotationSpeed * Time.deltaTime); // Allows for the rotation of all 3 axes to be changed in Inspector
    }
}
