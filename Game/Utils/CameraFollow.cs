using UnityEngine;

namespace GZ.Utils {

    public class CameraFollow : MonoBehaviour {

        public GameObject player;
        public float SlerpFactor = 1;
        private Vector3 offset;
        private Vector3 startposition;

        void Start () {
            offset = transform.position - player.transform.position;
            startposition = transform.position;
        }

        // LateUpdate is called after Update each frame
        void LateUpdate () {
            transform.position = Vector3.Slerp (transform.position, new Vector3(player.transform.position.x, startposition.y, player.transform.position.z) + offset, SlerpFactor * Time.deltaTime);
        }
    }
}