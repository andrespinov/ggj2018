using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 2f;
	public float maxSpeed = 3f;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		//
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		string px = rb2d.position.x.ToString();
		string py = rb2d.position.y.ToString();




		
			if (v > 0)
			{
				rb2d.MovePosition(new Vector2(rb2d.position.x, rb2d.position.y + 0.25f));
			}
			else if (v < 0)
			{
				rb2d.MovePosition(new Vector2(rb2d.position.x, rb2d.position.y - 0.25f));
			}
	
			if (h > 0)
			{
				rb2d.MovePosition(new Vector2(rb2d.position.x + 0.25f, rb2d.position.y));
			}
			else if (h < 0)
			{
				rb2d.MovePosition(new Vector2(rb2d.position.x - 0.25f, rb2d.position.y));
			}
		
	}
}
