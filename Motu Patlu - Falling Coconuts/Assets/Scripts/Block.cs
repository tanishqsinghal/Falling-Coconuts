using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	public float gravityScaleFactor = 20f;

	private Rigidbody2D bl;

	void Start()
	{
		//GetComponent<Rigidbody2D> ().gravityScale += Time.timeSinceLevelLoad / gravityScaleFactor;
		bl = GetComponent<Rigidbody2D>();
		bl.gravityScale += Time.timeSinceLevelLoad / gravityScaleFactor;
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Ground")
		{
			Destroy (gameObject);
		}

		if(col.gameObject.tag == "Player")
		{
			bl.gravityScale = -0.3f;
		}
	}

	void Update () {
		if(transform.position.y < -4f)
		{
			Destroy (gameObject);
		}
	}

}
