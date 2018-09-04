using UnityEngine;

public class DisableOnTriggerStay : MonoBehaviour
{
    public GameObject ObjectToEnable;

      void OnTriggerExit(Collider collision)
    {
        ObjectToEnable.SetActive(true);
    }

	
    void OnTriggerStay(Collider other)
	{
		 ObjectToEnable.SetActive(false);
	}
}
