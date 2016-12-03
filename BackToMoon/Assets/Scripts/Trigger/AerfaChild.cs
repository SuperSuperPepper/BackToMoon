using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AerfaChild : MonoBehaviour {
   
    public float offsetX = 3;


    private int i = 0;
    private Vector3 vec;
    private float timefirst;

    // Use this for initialization
    void Start () {
        i = 0;
        timefirst = Time.deltaTime;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

       
        i++;
        float value = Mathf.Sin(i);
        vec.x = value * offsetX;
        vec.y = transform.position.y;
        vec.z = transform.position.z;
        transform.Translate(vec);
        Debug.Log(value);
	}
}
