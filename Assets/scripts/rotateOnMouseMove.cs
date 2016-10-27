using UnityEngine;
using System.Collections;

public class rotateOnMouseMove : MonoBehaviour {
    public float speed = 1f;

	// Use this for initialization
	void Start () {
       
    }
 
    void Update(){
        transform.Rotate(new Vector3((Input.GetAxis("Mouse Y") * -1), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed);
        Debug.Log("Z: " + transform.rotation.z + "---- Z`: " + (transform.rotation.z * -1));
        transform.Rotate(new Vector3(0, 0, (transform.rotation.eulerAngles.z * -1)));
    }
}
