using UnityEngine;
using System.Collections;

public class ChestTimerDisplay : MonoBehaviour {
	public GameObject textTimer;

	// Use this for initialization
	void Start () {
		Instantiate(textTimer,transform.position + Vector3.up*0.5f -Vector3.right*2f,transform.rotation);
		transform.Rotate(20,0,0);

	
	}
	
	// Update is called once per frame
	void Update () {
	
		
	
	
	}
}
