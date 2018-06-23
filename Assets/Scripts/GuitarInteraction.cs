using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuitarInteraction : MonoBehaviour {

    public bool playingGuitar = false;
	public GameObject playerGuitar;
    PlayerInteraction myRay;
    PlayerController playerController;
    MouseLook mouseLook;
	public Rigidbody rigidBody;
    public AudioClip Anote;
	public AudioClip Bnote;
	public AudioClip Cnote;
	public AudioClip Dnote;
	public AudioClip Enote;
	public AudioClip Fnote;
	public AudioClip Gnote;

	public TextMeshProUGUI guitarInstruction;
	public TextMeshProUGUI guitarInstruction2;

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
			guitarInstruction.enabled = true;
			guitarInstruction2.enabled = false;
			playerGuitar.SetActive (true);
			if (Input.GetKeyDown (KeyCode.A)) {
				_audio.clip = Anote;
				_audio.Play ();
			}
			if (Input.GetKeyDown (KeyCode.B)) {
				_audio.clip = Bnote;
				_audio.Play ();
			}
			if (Input.GetKeyDown (KeyCode.C)) {
				_audio.clip = Cnote;
				_audio.Play ();
			}
			if (Input.GetKeyDown (KeyCode.D)) {
				_audio.clip = Dnote;
				_audio.Play ();
			}
			if (Input.GetKeyDown (KeyCode.E)) {
				_audio.clip = Enote;
				_audio.Play ();
			}
			if (Input.GetKeyDown (KeyCode.F)) {
				_audio.clip = Fnote;
				_audio.Play ();
			}
			if (Input.GetKeyDown (KeyCode.G)) {
				_audio.clip = Gnote;
				_audio.Play ();
			}
		} else {
			playerGuitar.SetActive (false);
			guitarInstruction.enabled = false;
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
