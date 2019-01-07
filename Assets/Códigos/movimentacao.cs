using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour {
    Rigidbody2D rigd = new Rigidbody2D();
    public float speed = 3;
	// Use this for initialization
	void Start () {
        rigd = gameObject.GetComponent <Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rigd.velocity = transform.right * speed;
    }

    private void FixedUpdate()
    {

    }

    public void Jump ()
    {
        transform.Translate(new Vector3(0, 1, 0));
    }

}
