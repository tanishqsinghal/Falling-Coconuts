using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

public class Button : MonoBehaviour {

	public AudioClip ch;
	public AudioClip bt;
	public AudioClip go;
	public AudioSource achi;

	public Player pl;
	public Fire fr;

	void Start()
	{
		pl.isGameOver = true;
	}

	public void Click()
	{
		achi.PlayOneShot (ch, 1f);
	}
		
	public void Bclick()
	{
		achi.PlayOneShot (bt, 0.5f);
	}

	public void Got()
	{
		achi.PlayOneShot (go, 1f);
	}
}
