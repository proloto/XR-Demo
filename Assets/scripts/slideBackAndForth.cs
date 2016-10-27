using UnityEngine;
using System.Collections;
using System;

public class slideBackAndForth : MonoBehaviour {
    public float translateScale;
    public float period;
    private Vector3 TranslationVector = new Vector3(0, 0, 0);
    private DateTime startTime;
	// Use this for initialization
	void Start () {
        startTime = DateTime.Now;
        Debug.Log("StartTime " + startTime);
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(new Vector3(getXVal(), getYVal(), 0));
	}

    private float getXVal()
    {
        float scale = (float)(translateScale * Math.Cos(((getElapsedTime() / 1000) * Math.PI) * period));
        return scale;
    }

    private float getYVal()
    {
        float scale = (float)(translateScale * Math.Sin(((getElapsedTime() / 1000) * Math.PI)*period));
        
        //Debug.Log("abs scale " + scale);
        return scale;
    }

    private double getElapsedTime()
    {
        TimeSpan span = DateTime.Now - startTime;
        //Debug.Log("span " + span.TotalMilliseconds);
        return span.TotalMilliseconds;
    }
}
