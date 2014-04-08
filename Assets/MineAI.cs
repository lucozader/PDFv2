using UnityEngine;
using System.Collections;

public class MineAI : MonoBehaviour {//attach to tower
	public GameObject bullet;
	public int direction = 1;///1 = up 0 = down 2 = left 3 = right
	public float distance = 200;
	public float bulletSpeed;
	public GameObject barrel;
	float timer;
	Vector3 test = new Vector3();

	// Use this for initialization
	void Start () {
	//InvokeRepeating("Spawn",0,15);

		Spawn ();
	
	
	}

	void Update (){
	


	}
	
	void Spawn(){
	
			if(direction == 1){
			test = new Vector3(0,0,distance);}
		if(direction == 0){
			 test = new Vector3(0,0,-distance);}
		if(direction == 2){
		 test = new Vector3(-distance,0,0);}
		if(direction == 3){
			 test = new Vector3(distance,0,0);}
		Vector3 test1 = new Vector3();
		 test1 = test + transform.position;
		GameObject newBullet = Instantiate(bullet,transform.position,transform.rotation) as GameObject;
		newBullet.rigidbody.AddForce((test1 - transform.position).normalized*bulletSpeed,ForceMode.VelocityChange);
		//float desired = newBullet.transform.position.z - transform.position.z;
	//	if(desired > distance){
			
		//}

	}



}
