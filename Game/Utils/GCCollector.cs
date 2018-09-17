using UnityEngine;

public class GCCollector : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Time.frameCount % 15 == 0) {
			System.GC.Collect();
		}
	}
}
