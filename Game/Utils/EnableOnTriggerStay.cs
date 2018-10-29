using UnityEngine;
namespace GZ.Utils {
    public class EnableOnTriggerStay : MonoBehaviour {
        public string tagToWatch = "Player";
        public GameObject ObjectToEnable;
        void Awake () {
            ObjectToEnable.SetActive (false);
        }
        void OnTriggerExit (Collider collision) {
            if (collision.gameObject.tag == tagToWatch)
                ObjectToEnable.SetActive (false);
        }

        void OnTriggerStay (Collider collision) {
            if (collision.gameObject.tag == tagToWatch)
                ObjectToEnable.SetActive (true);
        }
    }
}