using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarInteraction : MonoBehaviour {

    public bool playingGuitar = false;
	public GameObject playerGuitar;
    PlayerInteraction myRay;
    PlayerController playerController;
    MouseLook mouseLook;
	public Rigidbody rigidBody;
    public AudioClip Gnote;
    public StoryInteractable storyInteractable;
    AudioSource _audio;

    private void Start(){
        myRay = GameObject.Find("camera_parent").GetComponent<PlayerInteraction>();
        playerController = gameObject.GetComponent<PlayerController>();
        mouseLook = gameObject.GetComponent<MouseLook>();
        if (!storyInteractable) storyInteractable = GetComponent<StoryInteractable>();
        _audio = GetComponent<AudioSource>();
    }
	void Update(){      

        if (myRay.pickedUp)
        {
            //storyInteractable.isUsed = true;
			if (Input.GetKeyDown (KeyCode.Q)) {
				playerController.enabled = playingGuitar;
				mouseLook.enabled = playingGuitar;
				playingGuitar = !playingGuitar;
        }
		if (playingGuitar == true) {
			playerGuitar.SetActive (true);
			if (Input.GetKeyDown (KeyCode.G)) {
				//audio.Play();
				_audio.clip = Gnote;
				_audio.Play ();
				Debug.Log ("Strum");
			}
		} else {
			playerGuitar.SetActive (false);
		}
        }
    }
	void FixedUpdate(){
		if (playingGuitar == true) {
			rigidBody.isKinematic = true;
		} else {
			rigidBody.isKinematic = false;
		}
	}
}
