using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public float speed = 5f;

	private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {


		//Move paddle up or down.
		rb.MovePosition (
			new Vector2 (
				rb.position.x, rb.position.y + (Input.GetAxis ("Vertical") * Time.deltaTime * speed)
			)
		);
		
	}
}
