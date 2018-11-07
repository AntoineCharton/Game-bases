using UnityEngine;

namespace GZ.Utils {

	public class Billboard : MonoBehaviour {
		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {
			transform.LookAt (Camera.main.transform);
		}
	}
}