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
        void ActionInput(bool isActive);
        void FireInput(bool isActive);
        void FirstSecondaryInput(bool isActive);
        void JumpInput(bool isActive);
        void SecondSecondaryInput(bool isActive);
        void ThirdSecondaryInput(bool isActive);
        void FourthSecondaryInput(bool isActive);
        void FifthSecondaryInput(bool isActive);
        void WorldPositionInput(Vector3 worldPositionInput);
        void CancelInput(bool isActive);
    }
}
