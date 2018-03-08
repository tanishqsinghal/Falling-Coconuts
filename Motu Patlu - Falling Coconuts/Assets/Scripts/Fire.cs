using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

	public Player pl;

	public GameManager gm;

	public GameObject fire;
	public GameObject stand;
	public GameObject score;
	public GameObject bullet;

	IEnumerator Start ()
	{
		yield return new WaitForSeconds (6f);
		bullet.gameObject.SetActive (true);
		yield return new WaitForSeconds (2f);
		if(pl.isGameOver == true)
			pl.isGameOver = false;
		
		gm.heldTime = 0;
		fire.gameObject.SetActive (false);
		stand.gameObject.SetActive (true);
		score.gameObject.SetActive (true);
	}
	

}
