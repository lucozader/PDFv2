using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public GameObject spawn1;///template		
	public GameObject spawn2;///template	
		public GameObject spawn3;///template	
		public GameObject spawn4;///template	
		public GameObject spawn5;///template	
	public GameObject spawn6;///template	
	//	public GameObject spawn7;///template	
	//	public GameObject spawn8;///template	
	//public AudioClip etSound;
	//public AudioClip saturnSound;
	public AudioClip upgradeSound;
	//	public AudioClip sirenSound;
	public static int waveActivate;//this controls what wave is active//check guicontroller
	
	
	public bool once = false;
	public bool once2 = false;
	public bool once3 = false;
	public bool once4 = false;
	public bool once5 = false;

	public static float timer = 0;
	public static float timer2 = 0;

	
	
	
	
	// Use this for initialization
	void Start () {
		waveActivate=0;
		
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer+1*Time.deltaTime;
		timer2 = timer2+1*Time.deltaTime;

		//Debug.Log(DeadCount.numberDead);
		if(once == false && timer >5){
			transform.position = new Vector3(-1200, -340, 1200);
			GameObject pro1  = Instantiate (spawn1,transform.position,Quaternion.identity) as GameObject;///specific one
			pro1.GetComponent<EnemySpawner>().start = 0;
			pro1.GetComponent<EnemySpawner>().finish  = 5;

		

			once = true;
		
			pro1.GetComponent<EnemySpawner>().totalDelay = 5;



			waveActivate = 1;
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
		if(once4 == false && DeadCount.numberDead ==78){
			
			
			transform.position = new Vector3(-1200, -340, 1200);
			GameObject pro1  = Instantiate (spawn4,transform.position,Quaternion.identity) as GameObject;///specific one
			////transform.position = new Vector3(-25, 8, 0);
			//GameObject pro5  = Instantiate (spawn4,transform.position,Quaternion.identity) as GameObject;///specific one
			once4 = true;
			waveActivate = 4;
			
		}
		if(once5 == false && DeadCount.numberDead ==500){
			
			
			transform.position = new Vector3(-1200, -340, 1200);
			GameObject pro1  = Instantiate (spawn5,transform.position,Quaternion.identity) as GameObject;///specific one
			////transform.position = new Vector3(-25, 8, 0);
			GameObject pro2  = Instantiate (spawn6,transform.position,Quaternion.identity) as GameObject;///specific one
			once5 = true;
			waveActivate = 5;
			
		}
		
		
		
		if( timer == 900)
		{
			//GUIControllerFireEmblem.textbox = "Fecking UFO, Get out of the way!!!";
			//	audio.PlayOneShot(etSound);
		}
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
}
