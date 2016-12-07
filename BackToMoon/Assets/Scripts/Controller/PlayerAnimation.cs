using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {


    public Transform spere;

    public float Xoffic=0.32f;
    public float Yoffic=-0.42f;
    public float Zoffic=1.65f;


    private Quaternion startRotation;
    private Vector3 vec = new Vector3();
	
    // Use this for initialization
	void Start () {
     
        startRotation = this.transform.rotation;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        vec.x = spere.position.x + Xoffic;
        vec.y = spere.position.y + Yoffic;
        vec.z = spere.position.z + Zoffic;
        this.transform.position = vec;
        this.transform.rotation = startRotation;
	}
}
