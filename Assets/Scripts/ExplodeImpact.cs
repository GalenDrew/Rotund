using UnityEngine;
using System.Collections;

public class ExplodeImpact : MonoBehaviour {
    public float explosionForce;
    public GameObject collisionParticles;
    public GameObject explosionParticles;
    public float hitAllowance;


    private Rigidbody rb;
    private GameObject collisionParticlesStored;
    private GameObject explosionParticlesStored;
    private float hitStored;
    private int count;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision other)
    {
        if (hitStored < hitAllowance)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                hitStored = hitStored + 1;
                collisionParticlesStored = (GameObject)Instantiate(collisionParticles, transform.position, transform.rotation);
                collisionParticlesStored.transform.parent = gameObject.transform;
                Destroy(collisionParticlesStored, 0.5f);
                other.gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionForce * 1000, transform.position, 0, 1.0f);

            }
        }

        if (hitStored == hitAllowance)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                explosionParticlesStored = (GameObject)Instantiate(explosionParticles, transform.position, transform.rotation);
                gameObject.transform.parent = explosionParticlesStored.transform;
                Destroy(gameObject);
                Destroy(explosionParticlesStored, 0.5f);
                other.gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionForce * 1200, transform.position, 0, 1.0f);
            }
        }
    }

    }
