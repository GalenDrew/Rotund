using UnityEngine;
using System.Collections;

public class carDrive : MonoBehaviour {
    public float DriveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + new Vector3(0,0,DriveSpeed/100);
	}
}
