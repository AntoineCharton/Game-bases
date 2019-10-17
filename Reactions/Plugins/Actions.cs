
using UnityEngine;
public class Actions {
        
    public delegate void TriggerAction(GameObject gameObject);
    public delegate void TriggerActionState(GameObject gameObject, bool isActive);
}