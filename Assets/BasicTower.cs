using UnityEngine;
using System.Collections;

public class BasicTower : MonoBehaviour {
	public GameObject rangeIndicator;
	public GameObject bullet;
	public float bulletSpeed = 100f;
	public float fireRate = 1.0f;
	public  float fireRadius = 5.0f;
		public static float increase = 0.0f;
	bool once = false;
	// Use this for initialization
	bool once1 = false;
	GameObject temp;
	GameObject temp1;


	void Start ()
	{
		temp = GameObject.Find("GuiDisplay");	
		temp1 = GameObject.Find ("UICamera");



		InvokeRepeating("SpawnBullet",0,fireRate);
	}
			
	void SpawnBullet()
	
	{
		GameObject target = null;
		
		foreach(Collider col in Physics.OverlapSphere(transform.position, fireRadius))
		{
			if(col.tag == "Enemy")
			{
				target = col.gameObject;
				break;
			}
		}
		
		if(target != null)
		{
			GameObject newBullet = Instantiate(bullet,transform.position,bullet.transform.rotation) as GameObject;
			bullet.GetComponent<BulletRangeDestroy>().range = fireRadius;
			newBullet.rigidbody.AddForce((target.transform.position - transform.position).normalized*bulletSpeed,ForceMode.VelocityChange);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		//fireRadius = fireRadius+increase*(fireRadius/100);
		if(once1 == false){
			fireRadius = fireRadius*GUIControllerFireEmblem.ranger;
			once1 = true;}
	}
	void OnMouseEnter(){

			GameObject rangeFinder = Instantiate(rangeIndicator, transform.position, Quaternion.identity) as GameObject;
			StoreRange.rangee= fireRadius;
			
	
	}
	void OnMouseExit(){

		Destroy(GameObject.FindWithTag("Range"));

	}
	void OnMouseUp(){
		int i = 0;
		//funds = funds + funds for tower type/2//from 
		if(temp.GetComponent<GUIControllerFireEmblem>().boolFollow  == true){
			temp.GetComponent<GUIControllerFireEmblem>().boolFollow  = false;
			if(gameObject.tag == "RapiddTower"){
				i = 2;
			}
			if(gameObject.tag == "CannonTower"){
				i = 0;
			}
			if(gameObject.tag == "SlowTower"){
				i = 1;
			}
			EnergyManager.energy = EnergyManager.energy + 0.5f*temp1.GetComponent<TowerSelector>().towerCosts[i];
			Destroy (gameObject);
			}
	}


}
