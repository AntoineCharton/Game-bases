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


    public void FireInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].FireReaction)
            {
                try
                {
                    actions[i].FireReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].FireReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].FireReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void CancelInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].CancelReaction)
            {
                try
                {
                    actions[i].CancelReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].CancelReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].CancelReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void FirstSecondaryInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].FirstSecondaryReaction)
            {
                try
                {
                    actions[i].FirstSecondaryReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].FirstSecondaryReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].FirstSecondaryReaction)
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

    public void ActionInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].ActionReaction)
            {
                try
                {
                    actions[i].ActionReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].ActionReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].ActionReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void JumpInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].JumpReaction)
            {
                try
                {
                    actions[i].JumpReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].JumpReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].JumpReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void SecondSecondaryInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].SecondSecondaryReaction)
            {
                try
                {
                    actions[i].SecondSecondaryReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].SecondSecondaryReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].SecondSecondaryReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void ThirdSecondaryInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].ThirdSecondaryReaction)
            {
                try
                {
                    actions[i].ThirdSecondaryReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].ThirdSecondaryReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].ThirdSecondaryReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }

    public void FourthSecondaryInput(bool isActive)
    {
        for (var i = 0; i < actions.Count; i++)
        {
            if (reactions[i].FourthSecondaryReaction)
            {
                try
                {
                    actions[i].FourthSecondaryReaction(isActive);
                }
                catch (NotImplementedException)
                {
                    reactions[i].FourthSecondaryReaction = false;
                    if (i == actions.Count - 1)
                    {
                        for (var j = 0; j < reactions.Count; j++)
                        {
                            if (reactions[j].FourthSecondaryReaction)
                                return;
                        }
                        throw new NotImplementedException();
                    }
                };
            }
        }
    }
}