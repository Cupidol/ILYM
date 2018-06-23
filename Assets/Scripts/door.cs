using UnityEngine;
using System.Collections;
// using FMODUnity;

public class door : MonoBehaviour {

	private Animator _animator = null;
	/*
	private FMODUnity.StudioEventEmitter _fmodEventEmitter;
	private FMOD.Studio.EventInstance _Button;
	private FMOD.Studio.EventInstance _Ambient;
	*/
	public bool open = false;
	public AudioClip openDoor;
	public AudioSource doorAudio;

	void Start () {
		_animator = GetComponent<Animator>();
		doorAudio = GetComponent<AudioSource> ();
		/*
		_fmodEventEmitter = GetComponent<FMODUnity.StudioEventEmitter> ();
		_Button = FMODUnity.RuntimeManager.CreateInstance ("event:/Door Button");
		_Ambient = FMODUnity.RuntimeManager.CreateInstance ("event:/Ambience/Main Ambience");
		_Ambient.start ();
		*/
	}

	void Update(){
		//Debug.Log(_animator.GetBool("isopen"));
	}

	public void Toggle()
	{
		open = !open;
		if (open) {
			_animator.SetBool ("isopen", true);
			doorAudio.Play ();
			//_Button.start ();
		}else{
			_animator.SetBool ("isopen", false);
			doorAudio.Play ();
			//_fmodEventEmitter.Play();
		}
	}
}﻿
