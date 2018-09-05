using UnityEngine;

public class CameraFollow : MonoBehaviour {

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
        transform.position = Vector3.Slerp(transform.position, player.transform.position + offset, SlerpFactor * Time.deltaTime);
    }
}