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

        public void SecondInput(bool isActive)
        {
            ActionsCaller.SecondInput(isActive);
        }

        public void ThirdInput(bool isActive)
        {
            ActionsCaller.ThirdInput(isActive);
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

        public void FirstInput(bool isActive)
        {
            ActionsCaller.FirstInput(isActive);
        }

        public void FourthInput(bool isActive)
        {
            ActionsCaller.FourthInput(isActive);
        }

        public void FifthInput(bool isActive)
        {
            ActionsCaller.FifthInput(isActive);
        }

        public void SeventhInput(bool isActive)
        {
            ActionsCaller.SeventhInput(isActive);
        }

        public void SixthInput(bool isActive)
        {
            ActionsCaller.SixthInput(isActive);
        }
    }
}