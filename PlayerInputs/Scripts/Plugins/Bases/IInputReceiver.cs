using UnityEngine;

namespace GZ.PlayerInputs
{
    public interface IInputReceiver
    {
        void PrimaryDirection(Vector3 direction);
        void SecondaryDirection(Vector3 direction);
        void ThirdDirection(Vector3 direction);
        void FirstAnalog(float intensity);
        void SecondAnalog(float intensity);
        void FirstInput(bool isActive);
        void SecondInput(bool isActive);
        void ThirdInput(bool isActive);
        void FourthInput(bool isActive);
        void FifthInput(bool isActive);
        void SixthInput(bool isActive);
        void SeventhInput(bool isActive);
        void WorldPositionInput(Vector3 worldPositionInput);
    }
}
