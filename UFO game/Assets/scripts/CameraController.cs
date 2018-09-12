using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject p;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - p.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = offset + p.transform.position;
	}
}
