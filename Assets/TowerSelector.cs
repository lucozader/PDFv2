using UnityEngine;
using System.Collections;

public class TowerSelector : MonoBehaviour {
	public GameObject rangeFinder;
	public GameObject[] towerIcons;
	public GameObject[] towers;
	public int[] towerCosts;
public float scale = 0.1f;//this scales mouse icon size
	public float scale2 = 0.0001f;//this scales mouse icon size

	public bool once = false;
	public bool oncea = false;
	public float reducer = 0;



	GameObject mouseIcon;
	GameObject test;
	
	public float towerIconRotateRate = 1.0f;
	
	private int selectedTower = 0;

	// Use this for initialization
	void Start ()
	{ Vector3 start = new Vector3(10000f,10000f,10000f); 
		mouseIcon = Instantiate(towerIcons[0],start,transform.rotation) as GameObject;
		test = Instantiate(rangeFinder,start,Quaternion.identity) as GameObject;



	}
	
	// Update is called once per frame
	void Update ()
	{

	if(oncea == true){
		towerIcons[selectedTower].transform.Rotate(Vector3.up, towerIconRotateRate * Time.deltaTime);}
		if(oncea == true){
		//if(once == false){

		// mouseIcon = Instantiate(towerIcons[selectedTower],transform.position,transform.rotation) as GameObject;
		//	mouseIcon.transform.localScale = new Vector3(scale, scale, scale);

			//	once = true;}}
		mouseIcon.transform.position = camera.ScreenToWorldPoint( Input.mousePosition );///these lines create icon at mouse position
			//Vector3 adapt = new Vector3(0f,0f,0f);
			//adapt = camera.ScreenToWorldPoint( Input.mousePosition );
			//Vector3 adapt1 = new Vector3(0f,0f,0f);
		//	adapt1.x = adapt.x;
		//	adapt1.y = 60;
		//	adapt1.z = adapt.y;

			float xx = Input.mousePosition.x;
			float yy = Input.mousePosition.y;
			Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(xx, yy, 30));
			//	test.transform.position = adapt1;	
			test.transform.position = pos;///these lines create icon at mouse position



		}
		if(oncea == false){
			Destroy (test);
			Destroy (mouseIcon);
		}
	
	
	}
	
	public GameObject GetSelectedTower()
	{
		return towers[selectedTower];
	}
	
	public int GetSelectedTowerCost()
	{
		return towerCosts[selectedTower];
	}

	public bool GetSelectedTowerTrue()
	{
		return oncea;
	}
	
	void SetSelectedTower(GameObject inputTower)
	{ oncea = true;//this starts off with no tower selected
		int index = 0;
		foreach(GameObject towerIcon in towerIcons)
		{
			if(inputTower == towerIcon)
			{  
				selectedTower = index;
				Destroy(mouseIcon);
				Destroy(test);

				mouseIcon = Instantiate(towerIcons[selectedTower],camera.ScreenToWorldPoint( Input.mousePosition ),transform.rotation) as GameObject;
				mouseIcon.transform.localScale = new Vector3(scale, scale, scale);
				//test = Instantiate(rangeFinder,camera.ScreenToWorldPoint( Input.mousePosition ),Quaternion.identity) as GameObject;
			float	xx = Input.mousePosition.x;
			float	yy = Input.mousePosition.y;
			Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(xx, yy, 10));
				test = Instantiate(rangeFinder,pos,Quaternion.identity) as GameObject;
				if(towers[selectedTower].tag!="Miner"){		

					scale2=towers[selectedTower].GetComponent<BasicTower>().fireRadius;}

					test.transform.localScale = new Vector3(scale2*reducer, 0.01f, scale2*reducer);
				if(towers[selectedTower].tag=="Miner"){					test.transform.localScale = new Vector3(0, 0, 0);
				}




			}
			index++;
		}

	}
}
