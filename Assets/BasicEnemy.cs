using UnityEngine;
using System.Collections;

public class BasicEnemy : MonoBehaviour {//no slow
	//public Texture2D test1;
//	public Texture2D test2;
	public GameObject explosion;
	bool once = false;
	public float health = 10;
	public static float increase1 = 0;
	public GameObject chest;
	bool oncea = false;
	bool onceb = false;
	bool oncec =  false;
	bool ready = true;//
	float timer = 0;
	public GameObject fleas;
	GameObject flea;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		
		if(timer <5){
			if(oncea == true){
				ShipSmoothMove scriptInstance = gameObject.GetComponent<ShipSmoothMove>();
				scriptInstance.maxSpeed = scriptInstance.maxSpeed*0.5f;
				oncea = false;
				oncec = true;
			}
			
			if(oncec ==true){flea.transform.position = transform.position;}
			
			
			
			
		}
		
		
		
		if(timer>5&&onceb == true){
			ShipSmoothMove scriptInstance = gameObject.GetComponent<ShipSmoothMove>();
			scriptInstance.maxSpeed = scriptInstance.maxSpeed*2f;
			Destroy (flea);
			
			timer = 0;
			ready = true;
			onceb = false;
			oncec = false;
		}
		
		timer = timer+1*Time.deltaTime;
	
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.collider.tag == "Mortar")
		{
			//health= health - (health+ increase1*(health/100));
			//Instantiate(explosion, collision.contacts[0].point, Quaternion.identity);
			Destroy(collision.collider.gameObject);
		}
		if(collision.collider.tag == "RapidBullet")
		{
			int fool = Random.Range(0,3);
			if(fool == 0){
				health = health-1;}
			Destroy(collision.collider.gameObject);
		}
		if(collision.collider.tag == "Slow")
		{
			//health= health - (health+ increase1*(health/100));
			//health = health-1;
			//renderer.material.mainTexture = test2;
			//gameObject.GetComponent<ShipSmoothMove>().maxSpeed = 1;
			Destroy(collision.collider.gameObject);

			if(ready == true){
				//GameObject slowdown = Instantiate(slime, transform.position,transform.rotation) as GameObject;
			oncea = true;
				onceb = true;
				ready = false;}
		}
		if(collision.collider.tag == "Bullet")
		{
			//health= health - (health+ increase1*(health/100));
			health = health-2;
			Destroy(collision.collider.gameObject);
		}
			if(collision.collider.tag == "Explosion")
		{
			health = health -5;
			//Destroy(collision.collider.gameObject);
		}
	
		if(health <= 0&& once == false)
		{	GUIControllerFireEmblem.highScorePDF = GUIControllerFireEmblem.highScorePDF + 1000;// add 1000 to high score
			DeadCount.numberDead+= 1;
			Destroy(collision.collider.gameObject);
			once = true;
		

				//EnergyManager.energy += energyBonus;
				//	Quaternion pathObjectOrientation = Quaternion.LookRotation(pathPoints[0].transform.position - transform.position);
			Vector3 chestPosition  = new Vector3(transform.position.x,transform.position.y+30,transform.position.z);
			GameObject test = Instantiate(chest, chestPosition, Quaternion.identity) as GameObject;
			Destroy(gameObject);
		}
	}
}
