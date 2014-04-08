using UnityEngine;
using System.Collections;

public class Timer1 : MonoBehaviour {
	float timer;
	// Use this for initialization
	void Start () {
		timer = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer +1*Time.deltaTime;
	}
}
