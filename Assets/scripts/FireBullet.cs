using UnityEngine;
using System.Collections;

public class FireBullet : MonoBehaviour {

    public GameObject bullet;
    public float bulletVelocity = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("f"))
        {
            Debug.Log("F Key Pressed");
            fire();
        }
//        if (Input.GetTouch(0).phase == TouchPhase.Began)
//        {
//            fire();
//        }
        if (Input.GetMouseButtonDown(0))
        {
            fire();
        }
        if (Input.GetButton("FireBullet"))
        {
            Debug.Log("FireButtet Button");
            fire();
        }
    }

    public void fire()
    {
        var newbullet = (GameObject)Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation, gameObject.transform);
        newbullet.GetComponent<Rigidbody>().velocity = bulletVelocity * gameObject.transform.forward;
    }
}
