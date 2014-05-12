using UnityEngine;
using System.Collections;

public class BirdScript2 : MonoBehaviour {
	public GameObject flock;
	Vector3 victor = new Vector3(5000f,300f,4600f);
	float timer = 0;
	bool once = true;
	GameObject flock1;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		timer = timer+Time.deltaTime;
		if(timer > 90){
			flock1= Instantiate(flock,victor,Quaternion.identity) as GameObject;
			timer = 0;}
		if(transform.position.x<0){
			Destroy(flock1);
		}
		
	}
}