using UnityEngine;

public interface IActionPossibleNotification {
    void ActionPossible(string actionTag, GameObject gameObject);
    void ActionNotPossible(string actionTag, GameObject gameObject);
}