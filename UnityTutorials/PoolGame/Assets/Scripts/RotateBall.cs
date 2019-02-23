using UnityEngine;

public class RotateBall : MonoBehaviour {

	public float turnSpeed = 0.5f;
	private float angle;

	void LateUpdate () {
		if (Input.GetAxis("Horizontal")>0)
		{
			angle += turnSpeed;
		}
		else if (Input.GetAxis("Horizontal")<0)
		{
			angle -= turnSpeed;
		}
		transform.eulerAngles = new Vector3(0, angle, 0);
	}
}
