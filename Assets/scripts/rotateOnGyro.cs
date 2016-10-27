using UnityEngine;
using System.Collections;

public class rotateOnGyro : MonoBehaviour {

    public static float x = 0f;
    public static float y = 0f;
    public static float z = 0f;

	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
        UnityEngine.VR.InputTracking.Recenter();
    }
	
	// Update is called once per frame
	void Update () {
        //gameObject.transform.Rotate(Input.gyro.rotationRateUnbiased.x * -1, Input.gyro.rotationRateUnbiased.y * -1, Input.gyro.rotationRateUnbiased.z);
        var att = Input.gyro.attitude * Quaternion.identity;
        att = new Quaternion(att.x, att.y, -att.z, -att.w);
        Quaternion rot = Quaternion.Euler(90, 0, 0) * att;
        gameObject.transform.localRotation = rot;
    }
}
