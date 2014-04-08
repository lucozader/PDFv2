using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {
	float timerr = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timerr = timerr + 1*Time.deltaTime;
		//Debug.Log(timerr);
	}
}
