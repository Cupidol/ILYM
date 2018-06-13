using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {

	private Animator _animator = null;
	public bool open = false;

	void Start () {
		_animator = GetComponent<Animator>();
	}

	void Update(){
		//Debug.Log(_animator.GetBool("isopen"));
	}

	public void Toggle()
	{
		open = !open;
		if (open) {
			_animator.SetBool ("isopen", true);
		}else{
			_animator.SetBool ("isopen", false);
		}
	}
}﻿
