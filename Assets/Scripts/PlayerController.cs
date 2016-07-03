using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlayerController : MonoBehaviour {
	public float speed;
    public float jump;
    public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

    private int collideYes;

	void Start ()
	{
		/*creates a variable for the rigidbody component to apply forces to it*/
		rb = GetComponent<Rigidbody> ();

		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		/*Setting movement horizontal/vertical to be taken from the default unity horizontal/vertical inputs*/
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		/*takes the horizontal/vertical moves and converts them to a vector3 to work in 3d space*/
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

       
    }

    void OnTriggerEnter(Collider other) {
      /* 
       * unused for the time being*/
       if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
			rb.AddForce(0, 100, 0, ForceMode.Impulse);
            count = count + 1;
            SetCountText();
        }
		if (other.gameObject.CompareTag("Pick Up Scale")) {
			other.gameObject.SetActive(false);
			transform.localScale = transform.localScale * 3;

		}
    }

	/*Updates every frame to check for a trigger colliding with a collider (in this case the trigger is on the player)*/
    void OnTriggerStay(Collider other)
    {

		/*This sets up the conditional of the "Ground" tag for the jump*/
        if (other.gameObject.CompareTag("Ground"))
        {
			/*Adds upward force in a vector 3 based on the public variable of "jump"*/
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(0, jump, 0, ForceMode.Impulse);
            }

            if (Input.GetButtonDown("A"))
            {
                rb.AddForce(0, jump, 0, ForceMode.Impulse);
            }
        }
    }

	/*Currently Unused*/
       void SetCountText (){
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) {
			winText.text = "You Ween!";
		}
	}

    
}
