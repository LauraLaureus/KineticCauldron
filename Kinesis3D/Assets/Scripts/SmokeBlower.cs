﻿using UnityEngine;
using System.Collections;

public class SmokeBlower : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator> ();
	}
	
	public void blow(){
		animator.SetTrigger ("smokeWrong");
	}

	public void right(){
		animator.SetTrigger ("smokeRight");	
	}
}
