using UnityEngine;
using System.Collections.Generic;
[ExecuteInEditMode]
public class clonePrefab : MonoBehaviour {


	public GameObject prefab;
	public float objectCount;
	public Vector3 offset;
	public Vector3 Rotation;

	private Vector3 objOffset;
	private GameObject Clone;
	private Quaternion RotationPerUnit;


	[ContextMenu ("Apply")]
	// Use this for initialization
	void CreateClones()
		{		
		List<GameObject> children = new List<GameObject>();
		foreach (Transform child in transform) children.Add(child.gameObject);
		children.ForEach(child => DestroyImmediate(child));

		objOffset = transform.position;

		for (int i = 0; i < objectCount; i++) {
			RotationPerUnit = Quaternion.Euler(Rotation.x * i, Rotation.y * i, Rotation.z * i); 
			Clone = (GameObject)Instantiate (prefab, new Vector3 (objOffset.x + offset.x * i, objOffset.y + offset.y * i, objOffset.z + offset.z * i), RotationPerUnit);
			Clone.transform.parent = gameObject.transform;
		}
		}
	// Update is called once per frame
	/*void Update () {

	}*/
}
