using UnityEngine;

public class Billboard : MonoBehaviour {
	public Camera camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(Camera.main.transform);
	}
}
