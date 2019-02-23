using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FallingBalls : MonoBehaviour {

	public static float score;
	public static float ballCount;

	public Text displayedScore;

	private Collider other;

	private void Start()
	{
		score = 0;
		ballCount = 14;
		displayedScore.text = "Score: " + score.ToString();
	}
	private void OnTriggerExit(Collider other)
	{
		this.other = other;
		if (other.tag == "PlayBall")
		{
			score -= 1;
			Invoke("ResetWhiteBall", 1f);
			displayedScore.text = "Score: " + score.ToString();
		}
		else if(other.tag == "Ball")
		{
			score+=5;
			ballCount--;
			displayedScore.text = "Score: "+score.ToString();
		}
		else if(other.tag == "BlackBall")
		{
			SceneManager.LoadScene("GameOver");
		}
	}
	void ResetWhiteBall()
	{
		other.GetComponent<Rigidbody>().velocity = Vector3.zero;
		other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		other.transform.SetPositionAndRotation(new Vector3(0f, 0f, -2.4f), Quaternion.Euler(0, 0, 0));
	}
}
