using UnityEngine;
using System.Collections;

public class AttackSheep : MonoBehaviour {
	public GameObject bullet1;
	GameObject test;
	GameObject find;
	public GameObject smallExplosion;
	bool once = true;
	float bulletSpeed = 200;
	// Use this for initialization
	void Start () {
		
		find = GameObject.FindGameObjectWithTag("Sheep");
	}
	
	// Update is called once per frame
	
	void Update () {
		

		
		if(transform.position.x>160 && once == true){

			Vector3 victor = new Vector3(0f,transform.position.y+200,0f);

			test  = Instantiate (bullet1,transform.position+victor,Quaternion.identity) as GameObject;///specific one
		test.rigidbody.AddForce((find.transform.position - transform.position).normalized*bulletSpeed,ForceMode.VelocityChange);
			once = false;
		}
		if(once == false&& test!= null){
			if(test.transform.position.z>2800f){
				GameObject explosion = Instantiate(smallExplosion, find.transform.position,Quaternion.identity) as GameObject;
				Destroy(find);
				Destroy (test);
			
			}}
		}
		

		
	}
	
	
	
