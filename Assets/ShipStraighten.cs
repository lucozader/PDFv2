using UnityEngine;
using System.Collections;

public class ShipStraighten : MonoBehaviour {
	public float xRotation = 0f;
	public float yRotation = 20f;
	public float zRotation = 0f;
	
	void Start(){
		transform.Rotate(xRotation,yRotation,zRotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
