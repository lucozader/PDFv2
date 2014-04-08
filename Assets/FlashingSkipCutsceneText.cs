using UnityEngine;
using System.Collections;

public class FlashingSkipCutsceneText : MonoBehaviour {
	float timer;

	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(timer < 1){
			renderer.material.color = Color.yellow;
			timer = timer+1*Time.deltaTime;
		}
		if(timer>1){
			renderer.material.color = Color.red;
			timer = timer+1*Time.deltaTime;
		}
		if(timer>2){
			timer = 0;
		}
	}
	void OnMouseUp()
	{
		
	}
}
