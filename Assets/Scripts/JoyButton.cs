﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyButton : MonoBehaviour {
    [HideInInspector]
    protected bool Pressed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = true;
    }
}
