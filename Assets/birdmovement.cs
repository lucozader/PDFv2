using UnityEngine;
using System.Collections;

public class birdmovement : MonoBehaviour {
	 Vector3 victor = new Vector3(-500,0,500);

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position+victor*Time.deltaTime;
	
	}
}
