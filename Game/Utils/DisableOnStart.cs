using UnityEngine;

namespace GZ.Utils {
	public class DisableOnStart : MonoBehaviour {

		// Use this for initialization
		void Start () {
			gameObject.SetActive (false);
		}
	}
}