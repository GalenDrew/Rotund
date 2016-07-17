using UnityEngine;
using System.Collections;

public class swapWithPrefab : MonoBehaviour {

    public GameObject Prefab;

    private GameObject newPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            newPrefab = (GameObject)Instantiate(Prefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
   }
