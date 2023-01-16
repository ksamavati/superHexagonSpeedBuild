using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{
    Mesh playerMesh;
    Vector3[] vertices;
    int[] triangles;
    
    // Start is called before the first frame update
    void Start()
    {
        playerMesh = new Mesh();
        GetComponent<MeshFilter>().mesh = playerMesh;

        CreateShape();
        UpdateMesh();
    }

    void UpdateMesh()
    {
        playerMesh.Clear();

        playerMesh.vertices = vertices;
        playerMesh.triangles = triangles;

        playerMesh.RecalculateNormals();
    }

    void CreateShape()
    {
        vertices = new Vector3[]
        {
            new Vector3 (-0.1f,1,0),
            new Vector3 (0,1.1f,0),
            new Vector3 (0.1f,1,0)
        };

        triangles = new int[]
        {
            0, 1, 2
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
