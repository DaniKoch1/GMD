using UnityEngine;

public class AimCursor : MonoBehaviour {
	
	void Update()
	{
		RaycastHit hit;
		//draw line if it has an obstacle in front
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
		{
			//Debug.DrawRay(transform.position, transform.TransformDirection(new Vector3(1,0,0)) * hit.distance, Color.red, 20, true);
			DrawLine(transform.position, GameObject.Find("Aim").transform.position, Color.red);
		}
	}
	void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 0.02f)
	{
		GameObject myLine = new GameObject();
		myLine.transform.position = start;
		myLine.AddComponent<LineRenderer>();
		LineRenderer lr = myLine.GetComponent<LineRenderer>();
		lr.SetColors(color, color);
		lr.SetWidth(0.1f, 0.1f);
		lr.SetPosition(0, start);
		lr.SetPosition(1, end);
		GameObject.Destroy(myLine, duration);
	}
}
