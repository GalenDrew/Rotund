using UnityEngine;
using System.Collections;

public class ClickDragUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            transform.position = Input.mousePosition;
            Debug.Log("mouse click");
        }
	}
}
