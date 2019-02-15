
[System.Serializable]
public class ImplementedReactions
{
    public bool PrimaryDirectionReaction;
    public bool SecondaryDirectionReaction;
    public bool ThirdDirectionReaction;
    public bool FirstAnalogReaction;
    public bool SecondAnalogReaction;
    public bool ActionReaction;
    public bool FireReaction;
    public bool FirstSecondaryReaction;
    public bool JumpReaction;
    public bool SecondSecondaryReaction;
    public bool ThirdSecondaryReaction;
    public bool FourthSecondaryReaction;
    public bool WorldReaction;
    public bool CancelReaction;

    public ImplementedReactions()
    {
        PrimaryDirectionReaction = true;
        SecondaryDirectionReaction = true;
        ThirdDirectionReaction = true;
        FirstAnalogReaction = true;
        SecondAnalogReaction = true;
        ActionReaction = true;
        FireReaction = true;
        FirstSecondaryReaction = true;
        JumpReaction = true;
        SecondSecondaryReaction = true;
        ThirdSecondaryReaction = true;
        FourthSecondaryReaction = true;
        WorldReaction = true;
        CancelReaction = true;
    }
}