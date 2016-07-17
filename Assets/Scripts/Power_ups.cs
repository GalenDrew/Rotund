using UnityEngine;
using System.Collections;

public class Power_ups : MonoBehaviour {
    private Rigidbody rb;
    public GameObject prefab;
    private bool locker;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        locker = false;
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
	if(locker = false)
      if (other.gameObject.CompareTag("Player"))
        {
                locker = true;
            //rb.AddForce(0, 100, 0, ForceMode.Impulse);
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
