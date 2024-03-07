using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Icosaedro : MonoBehaviour
{

    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        Create();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Create()
    {
        Vector3[] vertices = {
            new Vector3(0, 0, 0),
            new Vector3(2f, 0, 0),
            new Vector3(1f, 1.73f, 0),
            new Vector3(1f, -1.29f, 1.15f),

            new Vector3(2.62f, 1.51f, 1.15f),
            new Vector3(-0.62f, 1.51f, 1.15f),
            new Vector3(-0.62f, -0.36f, 1.87f),
            new Vector3(2.62f, -0.36f, 1.87f),

            new Vector3(1f, 2.45f, 1.87f),
            new Vector3(1f, -0.58f, 3.02f),

            new Vector3(2f, 1.15f, 3.02f),
            new Vector3(0f, 1.15f, 3.02f),



            new Vector3(0, 0, 0),
            new Vector3(1f, 1.73f, 0),
            new Vector3(0, 0, 0),
            new Vector3(2f, 1.15f, 3.02f),

            new Vector3(1f, 1.73f, 0),
            new Vector3(0f, 1.15f, 3.02f),

            new Vector3(0, 0, 0),
            new Vector3(1f, 1.73f, 0),
            new Vector3(0, 0, 0),
            new Vector3(2f, 1.15f, 3.02f),

            new Vector3(1f, 1.73f, 0),
            new Vector3(0f, 1.15f, 3.02f),

        };

        int[] triangles = {
            2,3,1,
            5,3,2,
            5,3,9,
            6,9,3,
            6,7,1,
            4,7,1,
            8,4,2,
            5,8,2,
            9,11,5,
            12,9,6,
            7,12,6,
            10,7,4,
            10,4,8,
            11,8,5,
            11,9,8,
            10,12,7,
            11,8,12,
            10,11,12,
            6, 1, 3,
            12, 7, 6


        };



        Vector2[] uvs = {
            new Vector2(0, 0.11f),
            new Vector2(0.2f, 0),
            new Vector2(0.2f, 0.22f),
            new Vector2(0.4f, 0.11f),

            new Vector2(0.4f, 0.33f),
            new Vector2(0.6f, 0.22f),
            new Vector2(0.6f, 0.44f),
            new Vector2(0.8f, 0.33f),

            new Vector2(0.8f, 0.55f),
            new Vector2(1, 0.44f),

            new Vector2(1, 0.66f),
            new Vector2(1, 0.88f),

            new Vector2(0.8f, 1),
            new Vector2(0.8f, 0.77f),
            new Vector2(0.6f, 0.88f),

            new Vector2(0.6f, 0.66f),
            new Vector2(0.4f, 0.77f),

            new Vector2(0.4f, 0.55f),
            new Vector2(0.2f, 0.66f),

            new Vector2(0.2f, 0.44f),
            new Vector2(0, 0.55f),

            new Vector2(0, 0.33f),
            
        };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = material;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
