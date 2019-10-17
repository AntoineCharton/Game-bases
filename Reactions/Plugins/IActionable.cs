public interface IActionable
{
    void RegisterAction(Actions.TriggerAction triggerAction);
    void UnregisterAction(Actions.TriggerAction triggerAction);
    void RegisterFireAction(Actions.TriggerAction triggerAction);
    void UnRegisterFireAction(Actions.TriggerAction triggerAction);
    void RegisterFirstSecondary(Actions.TriggerActionState triggerAction);
    void UnRegisterFirstSecondary(Actions.TriggerActionState triggerAction);
    void RegisterFourth(Actions.TriggerAction triggerAction);
    void UnRegisterFourth(Actions.TriggerAction triggerAction);
    void DisableFireing();
    void EnableFireing();
}
