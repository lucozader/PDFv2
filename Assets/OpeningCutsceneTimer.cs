using UnityEngine;
using System.Collections;

public class OpeningCutsceneTimer : MonoBehaviour {
	float timer;
	// Use this for initialization
	void Start () {
		timer = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(timer > 10){
			Application.LoadLevel("scene1");
		}
		timer = timer+1*Time.deltaTime;
	}
}
