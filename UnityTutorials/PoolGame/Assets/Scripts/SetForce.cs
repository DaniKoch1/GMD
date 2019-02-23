using UnityEngine;
using UnityEngine.UI;

public class SetForce : MonoBehaviour {

    public Rigidbody rb;
	public Text forceBar;
	//public GameObject barOfForcePosition;
	//public float initialForce=2500f;
	private float userForce;
	// Use this for initialization
	void Start () {
		Debug.Log("Let the game begin");
		//rb.AddForce(initialForce, 0, 0);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (Input.GetKey(KeyCode.Space))
		{
			if (userForce > 15000)
				userForce = 0;
			userForce +=Time.deltaTime*10000;
			forceBar.text = "Force: " + (userForce/10-40).ToString("0");
			//DrawLine(new Vector3(barOfForcePosition.transform.position.x, barOfForcePosition.transform.position.y, userForce / 10000), Color.yellow, 0.1f);
			//Debug.Log("X: " + barOfForcePosition.transform.position.x + " Y: " + userForce / 10000 + " Z: " + barOfForcePosition.transform.position.z);
		}
		if (Input.GetKeyUp(KeyCode.Space))
		{
			//DrawLine(new Vector3(userForce / 10000, 0, 0), Color.red, 0.3f);
			rb.AddRelativeForce(userForce, 0, 0);
			userForce = 0f;
		}
	}
	/*void DrawLine(Vector3 end, Color color, float duration = 0.2f)
	{
		Vector3 start = barOfForcePosition.transform.position;
		GameObject myLine = new GameObject();
		myLine.transform.position = start;
		myLine.AddComponent<LineRenderer>();
		LineRenderer lr = myLine.GetComponent<LineRenderer>();
		//lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
		lr.SetColors(color, color);
		lr.SetWidth(0.3f, 0.3f);
		lr.SetPosition(0, start);
		lr.SetPosition(1, end);
		//Debug.Log("x: " + end.x + " y: " + end.y + " z: " + end.z);
		GameObject.Destroy(myLine, duration);
	}*/

}
