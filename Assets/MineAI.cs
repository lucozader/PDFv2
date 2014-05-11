using UnityEngine;
using System.Collections;

public class MineAI : MonoBehaviour {//attach to tower
	public GameObject bullet;
	public int direction = 1;///1 = up 0 = down 2 = left 3 = right
	public float distance = 400;
	public float bulletSpeed;
	public GameObject barrel;
	public GameObject rangeIndicator;
	public int pedistal;
	public bool refire = false;

	Vector3 test = new Vector3();
	GameObject temp;
	GameObject temp1;
	public float timer = 0;

	// Use this for initialization
	void Start () {
	//InvokeRepeating("Spawn",0,15);
		temp = GameObject.Find("GuiDisplay");	
		temp1 = GameObject.Find ("UICamera");

		Spawn ();


	
	}

	void Update (){
	if(refire == true){
			timer = timer + Time.deltaTime;


		}
	if(timer >5 && refire == true){
			GameObject newBullet = Instantiate(bullet,transform.position,transform.rotation) as GameObject;
			newBullet.GetComponent<MineBulletAI>().pedistal = pedistal;
			newBullet.GetComponent<MineBulletAI>().direction = direction;

			refire = false;
			timer = 0;}

	


	}
	
	void Spawn(){///instantiate range indicators here
	
		//	if(direction == 1){
		//	test = new Vector3(0,0,10);}
		//if(direction == 0){
		//	 test = new Vector3(0,0,-1);}
	//	if(direction == 2){
	//	 test = new Vector3(-10,0,0);}
	//	if(direction == 3){
	//		 test = new Vector3(10,0,0);}
	//	newBullet.transform.position = newBullet.transform.position+test;

		//Vector3 test1 = new Vector3();
		// test1 = test + transform.position;
		GameObject newBullet = Instantiate(bullet,transform.position,transform.rotation) as GameObject;
		newBullet.GetComponent<MineBulletAI>().pedistal = pedistal;
		newBullet.GetComponent<MineBulletAI>().direction = direction;

		//newBullet.rigidbody.AddForce((test1 - transform.position).normalized*bulletSpeed,ForceMode.VelocityChange);


		//float desired = newBullet.transform.position.z - transform.position.z;
	//	if(desired > distance){
			
		//}

	}
	void OnMouseEnter(){
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
		GameObject attack = Instantiate(rangeIndicator, test1, Quaternion.identity) as GameObject;

		
		
	}
	void OnMouseExit(){
		
		//Destroy(GameObject.FindWithTag("MineAttack"));
		//	Destroy(GameObject.FindWithTag("Range"));
		
	}
	void OnMouseUp(){
		int i = 0;
		//funds = funds + funds for tower type/2//from 
		if(temp.GetComponent<GUIControllerFireEmblem>().boolFollow  == true){
			temp.GetComponent<GUIControllerFireEmblem>().boolFollow  = false;
			if(gameObject.tag == "Miner"){
				i = 3;
			}
			EnergyManager.energy = EnergyManager.energy + 0.5f*temp1.GetComponent<TowerSelector>().towerCosts[i];
			Destroy (gameObject);
		}
	}



}
