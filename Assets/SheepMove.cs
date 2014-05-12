using UnityEngine;
using System.Collections;

public class SheepMove : MonoBehaviour {
	float x = 8;
	bool up = true;
	Vector3 victor;
	// Use this for initialization
	void Start () {
		Vector3 victor = new Vector3();

	
	}
	
	// Update is called once per frame
	void Update () {
		if(x<50&&up == true){
		 victor = new Vector3(x+1*Time.deltaTime,0f,0f);
		}
			if(x>50){
				up = false;
			victor =  new Vector3(x-1*Time.deltaTime,0f,0f);
				if(x<0){up =true;
			}
		}
		transform.position = transform.position + victor;
	
	}
}
