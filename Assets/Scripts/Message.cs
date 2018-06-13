using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Message : MonoBehaviour {

    public string[] message;
    public TextMeshProUGUI textmesh;


    public void invoke() {
        StartCoroutine(PlayMessage());
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator PlayMessage(){
        for (int i = 0; i < message.Length; i++) {
           textmesh.text = message[i];
           yield return new WaitForSeconds(3);
        }
        textmesh.text = ""; 
        yield return null;
    }
}
