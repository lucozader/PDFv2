using UnityEngine;
using System.Collections;

public class dMovement2 : MonoBehaviour {
	Vector3 victor = new Vector3(-500,0,-500);


	// Use this for initialization
	void Start () {
		transform.Rotate(0,-90,0);


	}
	
	// Update is called once per frame
	void Update () {

		transform.position = transform.position+victor*Time.deltaTime;

	}
}
