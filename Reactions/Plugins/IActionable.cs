public interface IActionable
{
    void Register(Actions.TriggerAction triggerAction);
    void Unregister(Actions.TriggerAction triggerAction);
    void RegisterSecond(Actions.TriggerAction triggerAction);
    void UnRegisterSecond(Actions.TriggerAction triggerAction);
    void RegisterThird(Actions.TriggerAction triggerAction);
    void UnRegisterThird(Actions.TriggerAction triggerAction);
}
