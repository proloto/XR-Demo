using UnityEngine;
using System.Collections;

public class MakeSphere : MonoBehaviour {

    public GameObject PrefabToSpawn;
    public int DegreeInterval = 90;
    public float Radius = 1f;

    // Use this for initialization
    void Start () {
        for (int y = 90; y <= 270; y += DegreeInterval)
        {
            for (int i = 0; i < 360; i += DegreeInterval)
            {
                var myinstance = (GameObject)Instantiate(PrefabToSpawn, gameObject.transform.position, new Quaternion(), gameObject.transform);
                myinstance.name = "Quad-0-" + i.ToString();
                myinstance.transform.Translate(Radius  * new Vector3(0, Mathf.Sin(y * Mathf.Deg2Rad),0));
                myinstance.transform.Translate((Radius * Mathf.Cos(y * Mathf.Deg2Rad)) * new Vector3(Mathf.Cos(i * Mathf.Deg2Rad), 0, Mathf.Sin(i * Mathf.Deg2Rad)));
                myinstance.transform.LookAt(2 * myinstance.transform.position - transform.position);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

