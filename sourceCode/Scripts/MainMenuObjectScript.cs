﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuObjectScript : MonoBehaviour {

    public bool isActive = true;

    // Use this for initialization
    void Start ()
    {
        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.SetActive(isActive);
    }
}
