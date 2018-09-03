using UnityEngine;
using System.Collections.Generic;

public class TransformSpeed : MonoBehaviour {
	public List<GameObject> Targets ;
	private List<IGameInputReceiver> reactions;
	Vector3 lastPosition = Vector3.zero;
	float speed = 0;

	void Awake()
	{
		reactions = new List<IGameInputReceiver>();
		foreach(var target in Targets) {
			var reaction = target.GetComponent<IGameInputReceiver>();
			if(reaction != null)
				reactions.Add(reaction);
		}
	}

	void FixedUpdate()
	{
		//speed = (roo)
	}
}
