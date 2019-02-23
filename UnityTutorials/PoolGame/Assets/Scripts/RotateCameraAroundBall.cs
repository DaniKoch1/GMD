using UnityEngine;

public class RotateCameraAroundBall : MonoBehaviour {

	public float turnSpeed = 0.5f;
	public Transform ball;

	private Vector3 offset;
	private float yaw = 0.0f;
	private float pitch = 0.0f;

	void Start()
	{
		offset = new Vector3(ball.position.x, ball.position.y, ball.position.z);
	}

	void LateUpdate()
	{
		if (Input.GetKey(KeyCode.J))
			yaw += turnSpeed;
		else if (Input.GetKey(KeyCode.L))
			yaw -= turnSpeed;
		else if (Input.GetKey(KeyCode.K))
			pitch -= turnSpeed;
		else if (Input.GetKey(KeyCode.I))
			pitch += turnSpeed;
		else if (Input.GetKeyUp(KeyCode.J) || Input.GetKeyUp(KeyCode.L) || Input.GetKeyUp(KeyCode.K) || Input.GetKeyUp(KeyCode.I))
		{
			offset = Quaternion.Euler(pitch, yaw, 0.0f) * offset;
			transform.position = ball.position + offset;
			transform.LookAt(ball.position);
			yaw = 0.0f;
			pitch = 0.0f;
		}
	}
}
