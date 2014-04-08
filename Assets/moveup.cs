using UnityEngine;
using System.Collections;

public class moveup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 victor = new Vector3(transform.position.x,transform.position.y+40f,transform.position.z);
		transform.position=victor;
	
	}
	
	// Update is called once per frame
	void Update () {
	

	
	}
}
