using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetSceneByName("PoolGame").name);
	}
}
