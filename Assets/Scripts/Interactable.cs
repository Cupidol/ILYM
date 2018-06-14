using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour{
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
	public void ActivateObject(){
		//door.Toggle();
		if (!isExit && door != null) {
			door.Toggle ();
		} else if (door != null) {
			component.invoke();
		}
        Debug.Log("Ik word aangeroepen");
		if (component != null && !isPlayed){
            isPlayed = true;
            component.invoke();
        }
    }
}