using UnityEngine;
namespace GZ.Utils {
	public class GCCollector : MonoBehaviour {

		// Update is called once per frame
		void Update () {
			if (Time.frameCount % 60 == 0) {
				System.GC.Collect ();
			}
		}
	}
}