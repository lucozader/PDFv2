using UnityEngine;
using System.Collections;

public class CreateTowerOnClicked : MonoBehaviour
{
	//bool empty = true;
	public TowerSelector towerSelector;
	//public static float rangeRadius;
	public int mineDirection;

	void Start(){
	}
	void Clicked(Vector3 position)
	{
		if(EnergyManager.energy >= towerSelector.GetSelectedTowerCost())
		{ //Debug.Log(position.x);
		//	Debug.Log(position.z);
			//if(position.x>-14 &&position.x<-9&& position.z >6 && position.z <10){
			GameObject tower = towerSelector.GetSelectedTower();
			GameObject pro = Instantiate(tower,transform.position + Vector3.up*50f,tower.transform.rotation) as GameObject;
			//MineAI scriptInstance = pro.GetComponent<MineAI>();
		   // scriptInstance.direction = mineDirection;
			if(pro.tag == "Miner"){
			MineAI tm = pro.GetComponent<MineAI>();///incredibly useful
				tm.direction = mineDirection;}
			EnergyManager.energy -= towerSelector.GetSelectedTowerCost();//}
	
			//empty = false;

			
		}

	}



}
