using UnityEngine;

public class DisableOnTriggerStay : MonoBehaviour
{
    public GameObject ObjectToEnable;
    public string tagToWatch = "Player";

    void Awake()
    {
        ObjectToEnable.SetActive(true);
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == tagToWatch)
            ObjectToEnable.SetActive(true);
    }


    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == tagToWatch)
            ObjectToEnable.SetActive(false);
    }
}
