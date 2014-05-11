using UnityEngine;
using System.Collections;

public class StraightenShip : MonoBehaviour {
	public GameObject bullet1;
	bool once = false;
	bool once1 = false;
	bool once2 = false;

	// Use this for initialization
	void Start () {
		//transform.Rotate(0, 0, 0);
	}
	
	// Update is called once per frame

		void Update () {

			if(once == false){
				once = true;}
		if(transform.position.x > 5200&&once1 == false){
		
			GameObject test  = Instantiate (bullet1,transform.position,Quaternion.identity) as GameObject;///specific one
			once1 = true;
			GUIControllerFireEmblem.planetHealthLeft = GUIControllerFireEmblem.planetHealthLeft-20;//ADD LOGIC HERE TO DEDUCT HEALTH FROM PLAYER/BASE

		}
		if(transform.position.x > 5900&&once2 == false){
			DeadCount.numberDead  += 1;
			once2 = true;
			Destroy (gameObject);
		}
	}

	

}