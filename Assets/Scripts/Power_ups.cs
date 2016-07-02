using UnityEngine;
using System.Collections;

public class Power_ups : MonoBehaviour {
    private Rigidbody rb;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        /*  if (other.gameObject.CompareTag("Pick Up")) {
              other.gameObject.SetActive(false);
              count = count + 1;
              SetCountText();
          }*/
		
//        if (other.gameObject.CompareTag(""))
//        {
//            gameObject.SetActive(false);
//            rb.AddForce(0, 500, 0, ForceMode.Impulse);
//        }
    }
}
