using UnityEngine;
public interface IReactions {
    void PrimaryDirectionReaction (Vector3 direction);
    void SecondaryDirectionReaction(Vector3 direction);
    void ThirdDirectionReaction(Vector3 direction);
    void FirstAnalogReaction(float intensity);
    void SecondAnalogReaction(float intensity);
    void FirstReaction(bool isActive);
    void SecondReaction(bool isActive);
    void ThirdReaction(bool isActive);
    void FourthReaction(bool isActive);
    void FifthReaction(bool isActive);
    void SixthReaction(bool isActive);
    void SeventhReaction(bool isActive);
    void WorldReaction(Vector3 position);
}