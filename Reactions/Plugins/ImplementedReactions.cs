
[System.Serializable]
public class ImplementedReactions
{
    public bool PrimaryDirectionReaction;
    public bool SecondaryDirectionReaction;
    public bool ThirdDirectionReaction;
    public bool FirstAnalogReaction;
    public bool SecondAnalogReaction;
    public bool FirstReaction;
    public bool SecondReaction;
    public bool ThirdReaction;
    public bool FourthReaction;
    public bool FifthReaction;
    public bool SixthReaction;
    public bool WorldReaction;

    public ImplementedReactions()
    {
        PrimaryDirectionReaction = true;
        SecondaryDirectionReaction = true;
        ThirdDirectionReaction = true;
        FirstAnalogReaction = true;
        SecondAnalogReaction = true;
        FirstReaction = true;
        SecondReaction = true;
        ThirdReaction = true;
        FourthReaction = true;
        FifthReaction = true;
        SixthReaction = true;
        WorldReaction = true;
    }
}