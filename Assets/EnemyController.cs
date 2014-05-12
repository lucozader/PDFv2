using UnityEngine;
using System.Collections;


public class EnemyController : MonoBehaviour {
	public GameObject spawn1;///template		
	public GameObject spawn2;///template	
		public GameObject spawn3;///template	
		public GameObject spawn4;///template	
		public GameObject spawn5;///template	
	public GameObject spawn6;///template	
	public GameObject spawn7;///template	
	public GameObject spawn8;///template	
	public GameObject spawn9;///template	
	public GameObject spawn10;///template	
	public GameObject woman;
	GameObject woman1;
	string comment;
	bool cdd = false;
	public GameObject spawn11;///template	
	bool cd = false;
	public GameObject[] e;
	public GameObject smallExplosion;
	public GameObject scroll;
	GameObject scroll1;
	public GUIStyle  styley = null;
	float timerc = 0;
public Texture2D cursorImage; // Your cursor texture
public int cursorWidth = 512; // Your cursor size x
public int cursorHeight= 512; // Your cursor size y

	bool girlonce = false;

	//public AudioClip etSound;
	//public AudioClip saturnSound;
	public AudioClip upgradeSound;
	//	public AudioClip sirenSound;
	public static int waveActivate;//this controls what wave is active//check guicontroller
	bool oncerr = false;
	
	public bool once = false;
	public bool once2 = false;
	public bool once3 = false;
	public bool once4 = false;
	public bool once5 = false;
	public bool once6 = false;

	public static float timer = 0;
	public static float timer2 = 0;

	
	
	
	
	// Use this for initialization
	void Start () {
		waveActivate=0;
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
		//if(girlonce == false){
		//comment = "I Tess, leader of the Pirate Defence Force, will stop that dastardly pirate captain Bluebeard and his goons!";/////these 2 code lines for comments
			//girlonce = true;}
		timer = timer+1*Time.deltaTime;
		timer2 = timer2+1*Time.deltaTime;

		//Debug.Log(DeadCount.numberDead);
		if(once == false && timer >5){
			transform.position = new Vector3(-1200, -340, 1200);
			GameObject pro1  = Instantiate (spawn1,transform.position,Quaternion.identity) as GameObject;///specific one
			pro1.GetComponent<EnemySpawner>().start = 0;
			pro1.GetComponent<EnemySpawner>().finish  = 5;

	

		
			pro1.GetComponent<EnemySpawner>().totalDelay = 5;


			once = true;
			waveActivate = 1;


			comment = "This small ship is fast. It is weak against rapid fire bullets. It will not set off mines.";/////these 2 code lines for comments
			cd = true;///////////
		}
		if(once2 == false && DeadCount.numberDead==1){
			
			transform.position = new Vector3(-1200, -340, 1200);
			GameObject pro1  = Instantiate (spawn2,transform.position,Quaternion.identity) as GameObject;///specific one
			pro1.GetComponent<EnemySpawner>().start = 0;
			pro1.GetComponent<EnemySpawner>().finish  = 5;

			GameObject pro2  = Instantiate (spawn3,transform.position,Quaternion.identity) as GameObject;///specific one
			pro2.GetComponent<EnemySpawner>().start = 5;
			pro2.GetComponent<EnemySpawner>().finish  = 10;

			pro1.GetComponent<EnemySpawner>().totalDelay = 10;
			pro2.GetComponent<EnemySpawner>().totalDelay = 10;

			once2 = true;
			waveActivate = 2;
		}
		
		
		if(once3 == false && DeadCount.numberDead ==3){
			
			
			transform.position = new Vector3(-1200, -340, 1200);
			GameObject pro1  = Instantiate (spawn4,transform.position,Quaternion.identity) as GameObject;///specific one
			pro1.GetComponent<EnemySpawner>().start = 0;
			pro1.GetComponent<EnemySpawner>().finish  = 5;
			
			GameObject pro2  = Instantiate (spawn5,transform.position,Quaternion.identity) as GameObject;///specific one
			pro2.GetComponent<EnemySpawner>().start = 5;
			pro2.GetComponent<EnemySpawner>().finish  = 10;

			GameObject pro3  = Instantiate (spawn6,transform.position,Quaternion.identity) as GameObject;///specific one
			pro3.GetComponent<EnemySpawner>().start = 10;
			pro3.GetComponent<EnemySpawner>().finish  = 15;
			
			pro1.GetComponent<EnemySpawner>().totalDelay = 15;
			pro2.GetComponent<EnemySpawner>().totalDelay = 15;
			pro3.GetComponent<EnemySpawner>().totalDelay = 15;

			
			once3 = true;
			waveActivate = 3;

		}
		if(once4 == false && DeadCount.numberDead ==6){
			
			
			transform.position = new Vector3(-1200, -340, 1200);
			GameObject pro1  = Instantiate (spawn7,transform.position,Quaternion.identity) as GameObject;///specific one
			pro1.GetComponent<EnemySpawner>().start = 0;
			pro1.GetComponent<EnemySpawner>().finish  = 5;
			
			
			
			
			pro1.GetComponent<EnemySpawner>().totalDelay = 5;

	



			once4 = true;
			waveActivate = 4;
			
		}
		if(once5 == false && DeadCount.numberDead ==7){

			transform.position = new Vector3(-1200, -340, 1200);
			GameObject pro1  = Instantiate (spawn8,transform.position,Quaternion.identity) as GameObject;///specific one
			pro1.GetComponent<EnemySpawner>().start = 0;
			pro1.GetComponent<EnemySpawner>().finish  = 5;
			transform.position = new Vector3(2100, -340, 4000);/////////////////////////////////////////////////////////////////////

			GameObject pro2  = Instantiate (spawn9,transform.position,Quaternion.identity) as GameObject;///specific one
			pro2.GetComponent<EnemySpawner>().start = 5;
			pro2.GetComponent<EnemySpawner>().finish  = 10;
	
			
			pro1.GetComponent<EnemySpawner>().totalDelay = 10;
			pro2.GetComponent<EnemySpawner>().totalDelay = 10;


		

			once5 = true;
			waveActivate = 5;

			//////////////
			GameObject[] a = GameObject.FindGameObjectsWithTag("Miner");
			GameObject[] b = GameObject.FindGameObjectsWithTag("CannonTower");
			GameObject[] c = GameObject.FindGameObjectsWithTag("SlowTower");
			GameObject[] d = GameObject.FindGameObjectsWithTag("RapiddTower");
			e = new GameObject[a.Length+b.Length+c.Length+d.Length]; 
			for(int i = 0; i< a.Length+b.Length+c.Length+d.Length; i++){
				if(i<a.Length){
					e[i] = a[i];}
				if(i<b.Length&&i>=a.Length){
					e[i] = b[i];}
				if(i<c.Length&&i>=b.Length){
					e[i] = c[i];}
				if(i<d.Length&&i>=c.Length){
					e[i] = d[i];
				}
			}
			
			
			if(e.Length>1){
				int random =(int)Random.Range(0,e.Length-1);
				GameObject prox = Instantiate(smallExplosion,e[random].transform.position,Quaternion.identity) as GameObject;
				Destroy (e[random]);}
			
			/// //////////
			
		}
		
		
		
		if(once6 == false && DeadCount.numberDead ==13){
			
			
			transform.position = new Vector3(-1200, -340, 1200);
			GameObject pro1  = Instantiate (spawn4,transform.position,Quaternion.identity) as GameObject;///specific one
			pro1.GetComponent<EnemySpawner>().start = 0;
			pro1.GetComponent<EnemySpawner>().finish  = 5;
			
			GameObject pro2  = Instantiate (spawn5,transform.position,Quaternion.identity) as GameObject;///specific one
			pro2.GetComponent<EnemySpawner>().start = 5;
			pro2.GetComponent<EnemySpawner>().finish  = 10;
			
		
			
			pro1.GetComponent<EnemySpawner>().totalDelay = 10;
			pro2.GetComponent<EnemySpawner>().totalDelay = 10;

			
			
			once6 = true;
			waveActivate = 6;}

		if( timer == 2300)
		{
			//GUIControllerFireEmblem.textbox = "I like Majora's Mask, What a game!";
			
		}
		if( timer == 1500)
		{
			//GUIControllerFireEmblem.textbox = "Saturn 5 Rocket, Where is it going?";
			//	audio.PlayOneShot(saturnSound);
		}
		if( timer == 2600)
		{
			GUIControllerFireEmblem.textbox = "Upgrades Received";
			GUIControllerFireEmblem.upgrades= GUIControllerFireEmblem.upgrades+5;
			audio.PlayOneShot(upgradeSound);
		}
		if( timer == 2700)
		{
			//GUIControllerFireEmblem.textbox = "Second Wave Incoming";
			//audio.PlayOneShot(sirenSound);
		}
		if( timer == 3000)
		{
			//GUIControllerFireEmblem.textbox = "Damn Space Dragons!";
			
		}
		if( timer == 2500)
		{
			//GUIControllerFireEmblem.textbox = "Attack Wave 1 Survived";
		}
		if( timer == 4500)
		{
			//GUIControllerFireEmblem.textbox = "Here comes the cavalry!";
		}
		if( timer == 5200)
		{
			//GUIControllerFireEmblem.textbox = "Woot, New Firing Platforms!";
		}
		
		
		if( timer == 5300)
		{
			//GUIControllerFireEmblem.textbox = "Attack Wave 2 Survived";
		}
		
		
		if( timer == 5400)
		{
			//GUIControllerFireEmblem.textbox = "Upgrades Received";
			//	GUIControllerFireEmblem.upgrades= GUIControllerFireEmblem.upgrades+5;
			//audio.PlayOneShot(upgradeSound);
		}
		
		if( timer == 5500)
		{
			//GUIControllerFireEmblem.textbox = "Third and FINAL Wave Incoming";
			//	audio.PlayOneShot(sirenSound);
		}
	}
	void OnGUI (){
		timerc = timerc +Time.deltaTime;
		GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), cursorImage);

		if(cd == true){
			timerc = 0;
			cdd = true;
			oncerr=false;
			cd = false;
		}



		if(timerc<6&&cdd == true){
			GUI.Label (new Rect(870f,130f,150f,500f),comment,styley);

		}



		Vector3 victorx = new Vector3(0.725f,0.3f,0f);
		Vector3 victory = new Vector3(0.9f,0.4f,0f);

		if(timerc<6&oncerr == false&&cdd == true){
			oncerr= true;
			woman1 = Instantiate(woman,victory,Quaternion.identity) as GameObject;

			scroll1 = Instantiate(scroll,victorx,Quaternion.identity) as GameObject;

		}
		if(timerc>6){
			oncerr = false;
			cdd = false;
			Destroy (scroll1);
			Destroy (woman1);
		}
			
		

		
		}

}
