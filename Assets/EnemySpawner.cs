using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{public float delay;
	public float start;
	public float finish;
	public float totalDelay;
	public GameObject path;
	public GameObject baser;
	bool oncexx = true;
	//public GameObject [] pathPoints;

	public GameObject[] spawnList;
	public GameObject pathitem;
	public float spawnTime;
	bool once = false;
	float distance;
	bool once2 = true;
	public float x = -200f;
	public float y = 0f;
	public float z = 2200f;
	public GameObject graphicalPathObject;
	public Texture2D test;
	bool oncex = false;
	float timer = 0;
	bool oncey = true;
	public GameObject skull;
	private int spawnIndex = 0;
	
	
	// Use this for initialization
	void Start ()
	{

		//CreateGraphicalPathObjects();
	}

	//void OnGUI(){

		//GUI.depth= -400;
	//	GUI.Box(new Rect(0, 5, 100, 400), test);	}
	
	// Update is called once per frame
	void Update (){
		if(timer > totalDelay+1 && oncey == true){////////////starts attack after delay
			InvokeRepeating("Spawn", 0, spawnTime);
			oncey = false;}

		timer = timer+Time.deltaTime;
		//addin total delay = 5,10,15//always 15 in random mode//also once

		////add in delay 0, 5, 10
		if(once2==true&&timer>start+1 && timer<finish){///displays items once
			DrawPath ();
		for(int i = 0; i <spawnList.Length; i++){
			Vector3 victor = new Vector3(x,y,z);
			GameObject test = Instantiate(spawnList[i], victor, Quaternion.identity) as GameObject;
				if(oncex == false){
				Vector3 victor2 = new Vector3(-56,-40,1718);

					GameObject test1 = Instantiate(baser, victor2, Quaternion.identity) as GameObject;
					oncex = true;}
				Destroy(test.GetComponent<SmallShipStraighten>());
				test.transform.tag = "Temp";			
				test.transform.Rotate(0f,90f,180f);
			Destroy(test.GetComponent<ShipSmoothMove>());


				z = z - 200;

				}

			once2 = false;
		}
		if(timer>finish&&oncexx == true){///clean up
			DestroyItems();
			oncexx = false;

	}
	
	}
	
	void Spawn()
	{
		//Spawn/Instantiate next enemy in spawnlist
		GameObject reference = Instantiate(spawnList[spawnIndex], transform.position, Quaternion.identity) as GameObject;
		reference.GetComponent<ShipSmoothMove>().pathPoints = path.GetComponent<PathStorage>().pathway;

		spawnIndex++;
		if(spawnIndex >= spawnList.Length)
		{   
			CancelInvoke();
		}
		
		//Set enemy path information
		//reference.SendMessage("SetPathPoints", 		path.GetComponent<PathStorage>().pathway );
	}
	
	/* void CreateGraphicalPathObjects()
	{
		//Create object between transform.position and first waypoint
		Vector3 pathObjectPosition = ((pathPoints[0].transform.position - transform.position)*0.5f) + transform.position;
		Quaternion pathObjectOrientation = Quaternion.LookRotation(pathPoints[0].transform.position - transform.position);
		GameObject pathObject = Instantiate(graphicalPathObject, pathObjectPosition, pathObjectOrientation) as GameObject;
		Vector3 newScale = Vector3.one;
		newScale.z = (pathPoints[0].transform.position - transform.position).magnitude;
		pathObject.transform.localScale = newScale;
		
		Vector2 newTextureScale = Vector2.one;
		newTextureScale.y = (pathPoints[0].transform.position - transform.position).magnitude;
		pathObject.renderer.material.mainTextureScale = newTextureScale;
		
		for(int i = 1; i < pathPoints.Length; i++)
		{
			pathObjectPosition = ((pathPoints[i].transform.position - pathPoints[i-1].transform.position)*0.5f) + pathPoints[i-1].transform.position;
			pathObjectOrientation = Quaternion.LookRotation(pathPoints[i].transform.position - pathPoints[i-1].transform.position);
			pathObject = Instantiate(graphicalPathObject, pathObjectPosition, pathObjectOrientation) as GameObject;
			newScale = Vector3.one;
			//newScale += new Vector3(100f, 100f, 100f);//added
			newScale.z = (pathPoints[i].transform.position - pathPoints[i-1].transform.position).magnitude;
			pathObject.transform.localScale = newScale;
			
			newTextureScale = Vector2.one;
			//newTextureScale += new Vector2(0.1f, 0.1f);//added

			newTextureScale.y = (pathPoints[i].transform.position - pathPoints[i-1].transform.position).magnitude;
			pathObject.renderer.material.mainTextureScale = newTextureScale;
		}
		
	} */
	
	void OnDrawGizmos()
	{
		//Gizmos.DrawLine(transform.position, pathPoints[0].transform.position);
		//Debug.DrawLine(transform.position, pathPoints[0].transform.position);
		//if(once == false){
			
		//	for(int i = 1; i < pathPoints.Length; i++){
				/**{
			//Gizmos.DrawLine(pathPoints[i-1].transform.position, pathPoints[i].transform.position);
			Vector3  test = new Vector3();



		//	Debug.DrawLine(pathPoints[i-1].transform.position, pathPoints[i].transform.position);
				 distance = Vector3.Distance (pathPoints[i-1].transform.position, pathPoints[i].transform.position);
				distance = distance/200;
			for(float j = 0; j < 1; j= j + 1/distance){
				test = Vector3.Lerp(pathPoints[i-1].transform.position, pathPoints[i].transform.position,j);
				GameObject pathitem1 = Instantiate(pathitem, test, Quaternion.identity) as GameObject;
				}
				once = true;
			} **/
				
				//for(float j = 0; j < 1; j= j + 0.2f){
				//	test = Vector3.Lerp(transform.position, pathPoints[0].transform.position,j);
				//	GameObject pathitem1 = Instantiate(pathitem, test, Quaternion.identity) as GameObject;
				
				//	}
				
				
				
			//}
		//}
	}

	void DrawPath(){
		if(once == false){
			//LineRenderer pro = gameObject.GetComponent<LineRenderer>();
		//	pro.SetWidth(40f, 40f);
		//	pro.SetVertexCount(20);
		//	Vector3 victoria = new Vector3(5000f,5000f,5000f);

			for(int i = 0; i < path.GetComponent<PathStorage>().pathway.Length;i++){
				GameObject pro = Instantiate(skull, path.GetComponent<PathStorage>().pathway[i].transform.position,Quaternion.identity) as GameObject;
				if(i+1 < path.GetComponent<PathStorage>().pathway.Length){
					GameObject pro1 = Instantiate(skull, Vector3.Lerp (path.GetComponent<PathStorage>().pathway[i].transform.position,path.GetComponent<PathStorage>().pathway[i+1].transform.position,0.5f),Quaternion.identity) as GameObject;}
			}


		//	for(int i = 0; i < path.GetComponent<PathStorage>().pathway.Length;i++){
		//		pro.SetPosition(i,path.GetComponent<PathStorage>().pathway[i].transform.position);}
			
		//	for(int i = path.GetComponent<PathStorage>().pathway.Length;i<20;i++){
		//		pro.SetPosition(i,victoria);}




			once = true;
	
				}
			
				} 
	void DestroyItems(){
		//LineRenderer pro = gameObject.GetComponent<LineRenderer>();
		//Destroy (pro);
			GameObject[] gos;
			gos = GameObject.FindGameObjectsWithTag("Temp");
		foreach (GameObject go in gos) {Destroy (go);}
		GameObject prod = GameObject.FindGameObjectWithTag("Indicator");
		Destroy (prod);

		GameObject[] gos2;
		gos2 = GameObject.FindGameObjectsWithTag("Skull");
		foreach (GameObject go in gos2) {Destroy (go);}
	


	}

}