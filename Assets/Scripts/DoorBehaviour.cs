using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour{
	public bool isOpen = false;

	public void Toggle(){
		isOpen = !isOpen;

		if(isOpen){
			//Open animation
		}else{
			//Close animation
		}
	}
}
