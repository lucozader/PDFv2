using UnityEngine;
using System.Collections;

public class GUIControllerFireEmblem : MonoBehaviour {
	public AudioClip openingSound;
	public AudioClip exitSound;
	public AudioClip coinSound;
	public AudioClip multiSound;
	public static int planetHealthLeft = 100;
	public GameObject ball;///template	
	public bool boolFollow = false;
	
	float xx;
	float yy;


	//public static float range = 100;
	public static float ranger = 1;
	public static int highScorePDF;
	public GameObject destroyIcon;
	GameObject pro1;
	
	public static float funds = 500;
	public static float attack = 100;
	public static int upgrades = 5;
	
	
	public bool oneElf = true;
	public bool start = true;
	
	
	public static string textbox;
	float x = 10f;
	float y = 10f;
	float w = 100f;
	float h = 40f;
	GameObject temp;
	
	
	
	void Start()
	{
		pro1  = Instantiate (destroyIcon,transform.position,Quaternion.identity) as GameObject;///specific one

		//textbox = "Hello, Defend the Earth from Dastardly General Harris's forces!";
		//	audio.PlayOneShot(openingSound);
		highScorePDF = 0;

		
	}
	
	
	void Update(){
		xx = Input.mousePosition.x;
		yy = Input.mousePosition.y;
		Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(xx, yy, 12));
		if(boolFollow == false){
			Destroy (pro1);
		}
		if(boolFollow == true){
			pro1.transform.position = pos;}

		if(planetHealthLeft <= 0)
		{	planetHealthLeft = 100;
			funds = 1000;
			DeadCount.numberDead=0;
			EnemyController.timer = 0;
			Application.LoadLevel("endscene");//maby add death later on
		}
		
		//	if(DeadCount.numberDead == 4 && EnemyController.waveActivate == 10 )
		if(DeadCount.numberDead == 9)//maby add way to count automatically
			
		{	GUIControllerFireEmblem.highScorePDF = GUIControllerFireEmblem.highScorePDF+(planetHealthLeft*1000)/10;
			funds = 1000;
			DeadCount.numberDead=0;
			EnemyController.timer = 0;
			Application.LoadLevel("winscene");//maby add death later on
			
		} 
		
	}
	
	
	void OnGUI() {
		
		//	GUI.Box(new Rect(x+440,y,500,40), textbox);
		GUI.Box(new Rect(0,Screen.height-75,Screen.width,100), "");

		
		GUI.Box(new Rect(x,y,w,h), "Return To Menu");
		if(GUI.Button(new Rect(x+10,y+20,80,h-20),"Exit"))
		{
			start = false;
			textbox = "Bye, Thanks for playing!";
			
			//audio.PlayOneShot(exitSound);
			planetHealthLeft = 100;
			funds = 1000;
			DeadCount.numberDead=0;
			EnemyController.timer = 0;
			
			Application.LoadLevel("startscene");
		}

		GUI.Box(new Rect(x+100,y,w,h), "Destroy Tower");
		if(GUI.Button(new Rect(x+110,y+20,80,h-20),"Destroy"))
		{
			Destroy(pro1);
			pro1  = Instantiate (destroyIcon,transform.position,Quaternion.identity) as GameObject;///specific one
			boolFollow = true;



		}
		
		//GUI.Box(new Rect(x,y,w,h), "Range %");
		//	GUI.Box(new Rect(x,y+20,w,h-20), range.ToString());
		
		
		//if(GUI.Button(new Rect(x+10,y+20,80,20),"Multi")&& range > 0){
		//audio.PlayOneShot(multiSound);
		//transform.position = new Vector3(150, 22, 400);
		
		//	GameObject pro  = Instantiate (mball,transform.position,Quaternion.identity) as GameObject;///specific one
		//	transform.position = new Vector3(450, 22, 400);
		
		//GameObject pro1  = Instantiate (mball,transform.position,Quaternion.identity) as GameObject;///specific one
		//ballsLeft = ballsLeft -2;
		
		//balls1.noofballs = balls1.noofballs+2;
		
		//HighScoreText.condition = "THERE CAN BE ONLY ONE multiball per game!";
		//textbox = "THERE CAN BE ONLY ONE multiball try per game!";
		//start = false;
		
		
		
		//multiball = false;
		
		
		
		
		
		
		//GUI.Box(new Rect(x+110,y,w,h), "Attack %");
		//	GUI.Box(new Rect(x+110,y+20,w,h-20), attack.ToString());
		
		GUI.Box(new Rect(Screen.width-300,y,w,h), "Village Health");
		GUI.Box(new Rect(Screen.width-300,y+20,w,h-20), planetHealthLeft.ToString());
		
		GUI.Box(new Rect(Screen.width/2,y,w,h), "Defence Funds");
		funds = EnergyManager.energy;
		GUI.Box(new Rect(Screen.width/2,y+20,w,h-20), funds.ToString());
		
		GUI.Box(new Rect(300,y,w,h), "Score");
		GUI.Box(new Rect(300,y+20,w,h-20), highScorePDF.ToString());//display high score in game
		
		GUI.Box(new Rect(Screen.width-150,y,w,h), "Attack Wave");
		GUI.Box(new Rect(Screen.width-150,y+20,w,h-20), EnemyController.waveActivate.ToString());
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		//GUI.Box(new Rect(Screen.width-110,y,w,h), "Upgrade Points");
		//GUI.Box(new Rect(Screen.width-110,y+20,w,h-20), upgrades.ToString());
		
		//
		//GUI.Box(new Rect(Screen.width-110,Screen.height - 540,w,h), "Upgrade Health");
		/**	if(GUI.Button(new Rect(Screen.width-100,Screen.height -520,80,20),"Health +"))
		{
			if(upgrades > 0 && planetHealthLeft < 181){
			textbox = "Health Upgraded!";
			planetHealthLeft = planetHealthLeft + 20;
			upgrades = upgrades-1;}
			//audio.PlayOneShot(exitSound);
	
		}
			GUI.Box(new Rect(Screen.width-110,Screen.height - 490,w,h), "Upgrade Range");
		if(GUI.Button(new Rect(Screen.width-100,Screen.height -470,80,20),"Range +"))
		{
						if(upgrades > 0 && range < 181){

			textbox = "Range Upgraded";
			range = range + 20;
			upgrades = upgrades-1;
			BasicTower.increase = BasicTower.increase+20; }
			//audio.PlayOneShot(exitSound);
	
		} 
				GUI.Box(new Rect(Screen.width-110,Screen.height - 440,w,h), "Upgrade Attack");
		if(GUI.Button(new Rect(Screen.width-100,Screen.height -420,80,20),"Attack +"))
		{			if(upgrades > 0&& attack < 200){

			
			textbox = "Attack Upgraded";
				attack = attack +20;
			BasicEnemy.increase1 = BasicEnemy.increase1 + 20;
			upgrades = upgrades-1;}

	
		}
**/
		
	}
}
