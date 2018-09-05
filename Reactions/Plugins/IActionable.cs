using UnityEngine;

public interface IActionable {
	void Register(Actions.TriggerAction triggerAction);
	void Unregister(Actions.TriggerAction triggerAction);
}
