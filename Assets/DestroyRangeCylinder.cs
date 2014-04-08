using UnityEngine;
using System.Collections;

public class DestroyRangeCylinder : MonoBehaviour {
	bool once = false;
	float timer = 0;
	void Start(){		
	}


	void Update(){
		timer = timer + 1*Time.deltaTime;
		if(timer>1&&once ==false){Destroy(gameObject);
			once = true;}
	}
}
