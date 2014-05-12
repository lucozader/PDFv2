using UnityEngine;
using System.Collections;

public class GuiManager : MonoBehaviour {
	public GameObject background;

	public GameObject pirate;
	public GameObject scroll;
	public GameObject woman;
	float timer = 0;
	bool once = false;
	GameObject pirate1;
	GameObject scroll1;
	GameObject background1;
	GameObject woman2;
	GameObject scroll2;
	GameObject scroll3;
	GameObject scrollx;
	bool oncew = false;

	bool oncex = false;

	bool once1 = false;
	public GUIStyle  stylex = null;


	// Use this for initialization
	void Start () {			
	

	}
	
	// Update is called once per frame
	void Update () {
	

		timer = timer + Time.deltaTime;
		if(once == false){
			Vector3 victor = new Vector3(-0.6f,-0.2f,0f);
			Vector3 victor1 = new Vector3(-0.4f,-0.2f,0f);
			Vector3 victor2 = new Vector3(1.1f, 0.5f,0f);
			Vector3 victor3 = new Vector3(1.2f,-0.2f,0f);

			Vector3 victornnn= new Vector3(0.25f,-1.3f,0f);

			scrollx = Instantiate(scroll,victornnn,Quaternion.identity) as GameObject;
		
			
			pirate1 = Instantiate(pirate,victor, Quaternion.identity)as GameObject;
			woman2 = Instantiate(woman,victor2, Quaternion.identity)as GameObject;
			scroll2 = Instantiate(scroll,victor3, Quaternion.identity)as GameObject;

				
			scroll1 = Instantiate(scroll,victor1, Quaternion.identity)as GameObject;

			once = true;
			once1 = true;
			oncew = true;
		}

		if(oncex == false){
			Vector3 victorx = new Vector3(0.3f,0.4f,0f);
			background1 = Instantiate(background,victorx, Quaternion.identity)as GameObject;
			oncex = true;}

		Vector3 victoria = new Vector3(0.2f,0f,0f);

		
		
		if(once1==true&&pirate1.transform.position.x<-0.1f)
		{
			pirate1.transform.position = pirate1.transform.position+ victoria*Time.deltaTime;}
		
		if(once1==true&&scroll1.transform.position.x<0.3f)
		{
			scroll1.transform.position = scroll1.transform.position+ victoria*Time.deltaTime;}


		/////////////
	 
		//woman code
		Vector3 victoria2 = new Vector3(-0.2f,0f,0f);

		if(oncew==true&&woman2.transform.position.x>0.61f&&timer>12)
		{
			woman2.transform.position = woman2.transform.position+ victoria2*Time.deltaTime;}
		
		if(oncew==true&&scroll2.transform.position.x>0.3f&&timer>12)
		{
			scroll2.transform.position = scroll2.transform.position+ victoria2*Time.deltaTime;}

		/// ////////////
		
		if(once==true&&timer >10)
		{once1 = false;
			pirate1.transform.position = pirate1.transform.position- victoria*Time.deltaTime;
			scroll1.transform.position = scroll1.transform.position- victoria*Time.deltaTime;

		}

		if(once==true&&timer >22)
		{oncew = false;
			woman2.transform.position = woman2.transform.position- victoria2*Time.deltaTime;
			scroll2.transform.position = scroll2.transform.position- victoria2*Time.deltaTime;
			
		}

		if(timer>24&&scrollx.transform.position.y<-0.2f){
			Vector3 vicks = new Vector3(0f,1f,0f);
			scrollx.transform.position = scrollx.transform.position+vicks*Time.deltaTime;
		}
	

		if(timer>28){
			Application.LoadLevel("scene1");
		}
		if(Input.GetMouseButtonDown(0)){
			Application.LoadLevel("scene1");
		}

	}
	private void OnGUI(){
		if(timer>3.5&&timer<10){GUI.Label(new Rect(570,100,300,300),"Shiver me timbers, This village looks ripe for plunderin lads. Get the ships ready. We dine on good food and wenches tonight. Arrr..",stylex);}
		if(timer>17&&timer<22){GUI.Label(new Rect(550,100,300,300),"Pirate Defence Force, get the cannons ready! Let's teach these lecherous louts a lesson. They'll be shark food today!",stylex);}
		if(timer>26){GUI.Label(new Rect(500,200,300,300),"Pirate Defence Force! Get ready to defend !",stylex);}
		if(timer>3&&timer<10){GUI.Label(new Rect(10,10,300,300),"Press mouse button to skip cutscene.",stylex);}
		if(timer>14){GUI.Label(new Rect(10,10,300,300),"Press mouse button to skip cutscene.",stylex);}


			
		}

}