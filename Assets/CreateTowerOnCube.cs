﻿using UnityEngine;
using System.Collections;

public class CreateTowerOnCube : MonoBehaviour 
	{
		public TowerSelector towerSelector;
	bool empty = true;
	bool test = false;
		
		void Clicked(Vector3 position)
		{
	
		if(EnergyManager.energy >= towerSelector.GetSelectedTowerCost()&& empty == true&&test == true)
			{ 

			GameObject tower = towerSelector.GetSelectedTower();
				Instantiate(tower,transform.position + Vector3.up*0.5f,tower.transform.rotation);
				EnergyManager.energy -= towerSelector.GetSelectedTowerCost();//}
			empty = false;
				

			}
		}
	}

