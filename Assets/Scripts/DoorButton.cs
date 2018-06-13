using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour{
	public door door;
    Message component;
    bool isPlayed;

    private void Start()
    {
        component = GetComponent<Message>();
  
    }
    void Update () {
		
	}
	public void PressButton(){
		door.Toggle();
        //Debug.Log("Ik word aangeroepen");
        if (component != null && !isPlayed){
            isPlayed = true;
            component.invoke();
        }
    }
}