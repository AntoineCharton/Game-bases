using UnityEngine;

public class BounceYPositionAxisReaction : ReactionBehaviour, IReactions {
	private Vector3 startPosition;
	void Awake()
	{
		startPosition = transform.localPosition;
	}

    public override void FirstAnalogReaction(float intensity)
    {
        transform.localPosition = new Vector3(transform.localPosition.y, Mathf.Cos(intensity)  + startPosition.y , transform.localPosition.z);
    }
}
