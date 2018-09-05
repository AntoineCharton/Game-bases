using UnityEngine;

public class DisableOnTriggerStay : MonoBehaviour
{
    public GameObject ObjectToEnable;

    void Awake()
    {
        ObjectToEnable.SetActive(true);
    }

      void OnTriggerExit(Collider collision)
    {
        ObjectToEnable.SetActive(true);
    }

	
    void OnTriggerStay(Collider other)
	{
		 ObjectToEnable.SetActive(false);
	}
}
