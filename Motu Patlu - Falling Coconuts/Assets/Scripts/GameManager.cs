using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Player pl;

	public Text scoreText;
	public int score = 0;

	public Text hiScore;
	public Text currentScore;

	//public Text bestText;
	//public Text currentText;

	public float heldTime = 0.0f;

	public GameObject rst;
	public GameObject lft;
	public GameObject rght;


	void Start()
	{
		
	}

	void Update () {
		heldTime += Time.deltaTime;
		if(heldTime >= 1   && (pl.isGameOver == false)){
			score += (int)heldTime * 5;
			heldTime -= (int)heldTime;
			scoreText.text = score.ToString ();
		}

		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit ();
	}

	public void EndGame()
	{
		hiScore.gameObject.SetActive (true);
		currentScore.gameObject.SetActive (true);

		if(score > PlayerPrefs.GetInt("Best", 0))
			{
			PlayerPrefs.SetInt ("Best", score);
			}

		hiScore.text = "HI : " + PlayerPrefs.GetInt ("Best", 0).ToString ();
		currentScore.text = "CURRENT : "+ score.ToString();

		rst.gameObject.SetActive (true);
		lft.gameObject.SetActive (false);
		rght.gameObject.SetActive (false);
	}

	public void Restart()
	{
		//Time.timeScale = 1f;

		//Time.fixedDeltaTime = Time.fixedDeltaTime * pl.slowDownFactor;

		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

}
