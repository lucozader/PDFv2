using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour {
	public GameObject flock;
	Vector3 victor = new Vector3(6300f,300f,-907f);
	float timer = 0;
	bool once = true;
	GameObject flock1;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


		timer = timer+Time.deltaTime;
		if(timer > 60){
			 flock1= Instantiate(flock,victor,Quaternion.identity) as GameObject;
			timer = 0;}
		if(transform.position.x<0){
			Destroy(flock1);
				}

		}


	
	

}