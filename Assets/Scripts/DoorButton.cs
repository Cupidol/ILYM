using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour{
	public door door;
    Message component;
    bool isPlayed;
	public bool isExit;

    private void Start()
    {
        component = GetComponent<Message>();
  
    }
    void Update () {
		
	}
	public void PressButton(){
		//door.Toggle();
		if (!isExit) {
			door.Toggle ();
		} else {
			component.invoke();
		}
        //Debug.Log("Ik word aangeroepen");
		if (component != null && !isPlayed){
            isPlayed = true;
            component.invoke();
        }
    }
}