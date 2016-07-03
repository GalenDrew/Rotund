using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;
    private Vector3 offsetDynamic;
    private float cameraHieght;
    private float cameraPullback;

    private float cameraFocus;
    private Quaternion cameraRotate;
    private float cameraTurn;

   
	/*sets up the variable offset to be relevant to the position of the public variable "player"*/
    void Start () {
		offset = transform.position - player.transform.position - player.transform.up;
	}

    void Update ()
    {
		/*Defines camera height by the players y position. The math is calibration to get the camera y position correct*/
        cameraHieght = player.transform.position.y / 4 + 5;

		/*Defines camera pullback by the players y position. The math is calibration to get the camera z position correct*/
        cameraPullback = player.transform.position.y / 4 - 5;

		/*Defines offsetDynamic as a vector 3 with a clamped range for both y (camera height) and z (camera pullback)*/
		offsetDynamic = new Vector3 ( player.transform.position.x  / 100 , Mathf.Clamp(cameraHieght, 3, 15), Mathf.Clamp(cameraPullback, -6, 3));

		/*Defines camera focus by the players y position. The math is calibration to get the camera x rotation correct*/
        cameraFocus = player.transform.position.y / 4 + 3;

        

    

        /*Defines camera rotate as a new quaternion with a clamped range for the camera rotation based on cameraFocus*/
        cameraRotate = new Quaternion(Mathf.Clamp(cameraFocus, 0, 10), 0, 0, 10);

  
    }
	void LateUpdate () {
		/*adjusts the camera position based on the players position plus offsetdynamic and the rotation from cameraRotate*/
		transform.position = player.transform.position + offsetDynamic;
        //transform.rotation = cameraRotate;
        transform.LookAt(new Vector3 (player.transform.position.x, player.transform.position.y + 2, player.transform.position.z));

       /* if (Input.GetKey("d"))
        {
            transform.RotateAround(player.transform.position, Vector3.up, 1);
            Debug.Log(cameraTurn);
        }
        if (Input.GetKey("a"))
        {
            transform.RotateAround(player.transform.position, Vector3.up, -1);
            Debug.Log(cameraTurn);
        }*/
    }
}


