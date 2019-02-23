using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour {

	public Text displayedScore;
	private float score;
	private void Start()
	{
		score = FallingBalls.score;
		if (FallingBalls.ballCount == 0)
			score += 50;
		Debug.Log(score);
		displayedScore.text = "Your score: " + score.ToString();
	}
	void OnTriggerEnter()
	{
		Invoke("RestartGame", 0.5f);
	}
	void RestartGame()
	{
		SceneManager.LoadScene("PoolGame");
	}
}
