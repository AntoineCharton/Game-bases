using UnityEngine;
namespace GZ.Utils {
	public class FixedYPosition : MonoBehaviour {
		float fixedPosition = 0;
		// Use this for initialization
		void Awake () {
			fixedPosition = transform.position.y;
		}

		// Update is called once per frame
		void LateUpdate () {
			transform.position = new Vector3 (transform.position.x, fixedPosition, transform.position.z);
		}
	}
}