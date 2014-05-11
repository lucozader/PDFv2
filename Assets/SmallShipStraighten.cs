using UnityEngine;
using System.Collections;

public class SmallShipStraighten : MonoBehaviour {
	public GameObject bullet1;
	bool once = false;
	bool once1 = false;
	bool once2 = false;
	public GameObject test;
	
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	
	void Update () {

		transform.Rotate(0, 0, 180);


		
		if(once == false){
			once = true;}
		if(transform.position.x > 5200&&once1 == false){
			Vector3 victor = new Vector3(transform.position.x-200,transform.position.y,transform.position.z-200);
			test  = Instantiate (bullet1,victor,Quaternion.identity) as GameObject;///specific one
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