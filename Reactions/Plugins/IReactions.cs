using UnityEngine;
public interface IReactions {
    void PrimaryDirectionReaction (Vector3 direction);
    void SecondaryDirectionReaction(Vector3 direction);
    void ThirdDirectionReaction(Vector3 direction);
    void FirstAnalogReaction(float intensity);
    void SecondAnalogReaction(float intensity);
    void ActionReaction(bool isActive);
    void FireReaction(bool isActive);
    void FirstSecondaryReaction(bool isActive);
    void JumpReaction(bool isActive);
    void SecondSecondaryReaction(bool isActive);
    void ThirdSecondaryReaction(bool isActive);
    void FourthSecondaryReaction(bool isActive);
    void WorldReaction(Vector3 position);
    void CancelReaction(bool isActive);
}