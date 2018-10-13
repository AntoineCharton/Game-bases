using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ActionsCaller
{
    private List<IReactions> actions;
    public List<ImplementedReactions> reactions;
    public ActionsCaller(IReactions[] _reactions)
    {
        actions = new List<IReactions>(_reactions);
        reactions = new List<ImplementedReactions>();
        foreach (var action in actions)
        {
            reactions.Add(new ImplementedReactions());
        }
    }

    public void PrimaryDirection(Vector3 direction)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].PrimaryDirectionReaction)
            {
                try
                {
                    actions[i].PrimaryDirectionReaction(direction);
                }
                catch (NotImplementedException)
                {
                    reactions[i].PrimaryDirectionReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].PrimaryDirectionReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void SecondaryDirection(Vector3 direction)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].SecondaryDirectionReaction)
            {
                try
                {
                    actions[i].SecondaryDirectionReaction(direction);
                }
                catch (NotImplementedException)
                {
                    reactions[i].SecondaryDirectionReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].SecondaryDirectionReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void SecondInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].SecondReaction)
            {
                try
                {
                    actions[i].SecondReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].SecondReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].SecondReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void ThirdInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].ThirdReaction)
            {
                try
                {
                    actions[i].ThirdReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].ThirdReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].ThirdReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };

            }
        }
    }

    public void WorldPositionInput(Vector3 worldPosition)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].WorldReaction)
            {
                try
                {
                    actions[i].WorldReaction(worldPosition);
                }
                catch (NotImplementedException)
                {
                    reactions[i].WorldReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].WorldReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void ThirdDirection(Vector3 direction)
    {
        throw new NotImplementedException();
    }

    public void FirstAnalog(float intensity)
    {
        throw new NotImplementedException();
    }

    public void SecondAnalog(float intensity)
    {
        throw new NotImplementedException();
    }

    public void FirstInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].FirstReaction)
            {
                try
                {
                    actions[i].FirstReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].FirstReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].FirstReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void FourthInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].FourthReaction)
            {
                try
                {
                    actions[i].FourthReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].FourthReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].FourthReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void FifthInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].FifthReaction)
            {
                try
                {
                    actions[i].FifthReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].FifthReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].FifthReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void SixthInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].SixthReaction)
            {
                try
                {
                    actions[i].SixthReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].SixthReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].SixthReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

}