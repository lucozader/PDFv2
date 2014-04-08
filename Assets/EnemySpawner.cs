using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
	public GameObject[] pathPoints;
	public GameObject[] spawnList;
	public GameObject pathitem;
	public float spawnTime;
	bool once = false;
	float distance;
	
	public GameObject graphicalPathObject;
	
	private int spawnIndex = 0;
	
	
	// Use this for initialization
	void Start ()
	{
		InvokeRepeating("Spawn", 0, spawnTime);
		//CreateGraphicalPathObjects();
	}
	
	// Update is called once per frame
	void Update (){
	}
	
	
	
	void Spawn()
	{
		//Spawn/Instantiate next enemy in spawnlist
		GameObject reference = Instantiate(spawnList[spawnIndex], transform.position, Quaternion.identity) as GameObject;
		spawnIndex++;
		if(spawnIndex >= spawnList.Length)
		{   
			CancelInvoke();
		}
		
		//Set enemy path information
		reference.SendMessage("SetPathPoints", pathPoints);
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
		if(once == false){
			
			for(int i = 1; i < pathPoints.Length; i++){
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
				
				
				
			}
		}
	}
}