﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lùth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "Ghost")
        {
            coll.gameObject.GetComponent<PlayerManager>().IncreaseLùth(1);

            Destroy(gameObject);
        }
    }
}
