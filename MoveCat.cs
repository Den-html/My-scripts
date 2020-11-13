using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCat : MonoBehaviour {

	float  dirX, dirY;

	[SerializeField]
	float moveSpeed = 5f;

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		dirX = Input.GetAxis ("Horizontal") * moveSpeed;
		dirY = Input.GetAxis ("Vertical") * moveSpeed;
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector2 (dirX, dirY);
	}

}
