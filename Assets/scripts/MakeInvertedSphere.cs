using UnityEngine;
using System.Collections;

public class MakeInvertedSphere : MonoBehaviour {

    public GameObject preFab;
    public float radius = 1f;
    public int degreeRotate;

    // Use this for initialization
    void Start()
    {
        MeshFilter thisMeshFilter = GetComponent<MeshFilter>();
        Mesh myMesh = thisMeshFilter.mesh;
        for  (int i = 0; i < myMesh.vertexCount; i++)
        {
            myMesh.normals[i] = new Vector3(1 - myMesh.normals[i].x, 1 - myMesh.normals[i].y, 1 - myMesh.normals[i].z);
        }

        MeshCollider collider = GetComponent<MeshCollider>();
        collider.sharedMesh = myMesh;

        thisMeshFilter.mesh = myMesh;
    }
	// Update is called once per frame
	void Update () {
	    
	}
}
