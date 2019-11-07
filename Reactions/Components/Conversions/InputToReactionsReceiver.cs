using GZ.PlayerInputs;
using UnityEngine;

namespace GZ.Reactions
{
    public class InputToReactionsReceiver : MonoBehaviour, IInputReceiver
    {
        public ActionsCaller ActionsCaller;

        private void Awake()
        {
            ActionsCaller = new ActionsCaller(GetComponents<IReactions>());
        }

        public void PrimaryDirection(Vector3 direction)
        {
            ActionsCaller.PrimaryDirection(direction);
        }

        public void SecondaryDirection(Vector3 direction)
        {
            ActionsCaller.SecondaryDirection(direction);
        }

        public void FireInput(bool isActive)
        {
            ActionsCaller.FireInput(isActive);
        }

        public void FirstSecondaryInput(bool isActive)
        {
            ActionsCaller.FirstSecondaryInput(isActive);
        }

        public void WorldPositionInput(Vector3 worldPosition)
        {
            ActionsCaller.WorldPositionInput(worldPosition);
        }

        public void ThirdDirection(Vector3 direction)
        {
            ActionsCaller.ThirdDirection(direction);
        }

        public void FirstAnalog(float intensity)
        {
            ActionsCaller.FirstAnalog(intensity);
        }

        public void SecondAnalog(float intensity)
        {
            ActionsCaller.SecondAnalog(intensity);
        }

        public void ActionInput(bool isActive)
        {
            ActionsCaller.ActionInput(isActive);
        }

        public void JumpInput(bool isActive)
        {
            ActionsCaller.JumpInput(isActive);
        }

        public void SecondSecondaryInput(bool isActive)
        {
            ActionsCaller.SecondSecondaryInput(isActive);
        }

        public void FourthSecondaryInput(bool isActive)
        {
            ActionsCaller.FourthSecondaryInput(isActive);
        }

        public void ThirdSecondaryInput(bool isActive)
        {
            ActionsCaller.ThirdSecondaryInput(isActive);
        }

        public void FifthSecondaryInput(bool isActive)
        {
            ActionsCaller.FifthSecondaryInput(isActive);
        }

        public void CancelInput(bool isActive)
        {
            ActionsCaller.CancelInput(isActive);
        }
    }
}