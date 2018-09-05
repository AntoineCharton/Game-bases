using UnityEngine;

public class FollowStrictly : MonoBehaviour {


    public GameObject player;
	public float SlerpFactor = 1;

    private Vector3 offset;

    void Start () 
    {
        offset = transform.position - player.transform.position;
    }
    
    // LateUpdate is called after Update each frame
    void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
		transform.rotation = player.transform.rotation;
    }
}
