using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateOnTriggerEnter : MonoBehaviour {
    public string TagTrigger = "Player";
    public GameObject ObjectToRotate;
    public Vector3 TargetRotation;
    public Vector3 StartRotation;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == TagTrigger)
            ObjectToRotate.transform.DOLocalRotate(TargetRotation, 0.3f);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == TagTrigger)
            ObjectToRotate.transform.DOLocalRotate(StartRotation, 0.3f);
    }
}
