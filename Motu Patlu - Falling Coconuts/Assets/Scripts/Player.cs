using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	public float speed = 15f;
	public float mapwidth = 5f;

	public float move = 2f;

	public bool isGameOver = true;

	public Rigidbody2D rb;

	public GameObject scr;
	public GameObject scr1;
	public GameObject gg;

	public float slowDownFactor = 1000f;

	void Start ()
	{
		
	}
		

	void FixedUpdate()
	{

	}

	public void left()
	{
		if(rb.position.x >= -1f && !isGameOver)
		{
			rb.position = new Vector2((rb.position.x - move), rb.position.y);
		}
	}

	public void right()
	{
		if(rb.position.x <= 1f && !isGameOver)
		{
			rb.position = new Vector2(rb.position.x + move, rb.position.y);
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Block")
		{

			Handheld.Vibrate ();



			isGameOver = true;

			//Time.timeScale = 1f / slowDownFactor;

			//Time.fixedDeltaTime = Time.fixedDeltaTime / slowDownFactor;


			scr.gameObject.SetActive (false);
			scr1.gameObject.SetActive (false);
			gg.gameObject.SetActive (false);
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}

}
