using UnityEngine;

public class EnableOnTriggerStay : MonoBehaviour {

    public GameObject ObjectToEnable;
    void Awake()
    {
        ObjectToEnable.SetActive(false);
    }
      void OnTriggerExit(Collider collision)
    {
        ObjectToEnable.SetActive(false);
    }

	
    void OnTriggerStay(Collider other)
	{
		 ObjectToEnable.SetActive(true);
	}
}
