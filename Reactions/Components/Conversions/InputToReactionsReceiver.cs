using System;
using PlayerInputs;
using UnityEngine;

namespace Reactions
{
    public class InputToReactionsReceiver : MonoBehaviour, IInputReceiver
    {
        private IReactions action;

        private void Awake()
        {
            action = GetComponent<IReactions>();
        }

        public void FifthInput(bool isActive)
        {
             action.FifthReaction(isActive);
        }

        public void FirstAnalog(float intensity)
        {
            action.FirstAnalogReaction(intensity);
        }

        public void FirstInput(bool isActive)
        {
            action.FirstReaction(isActive);
        }

        public void FourthInput(bool isActive)
        {
            action.FourthReaction(isActive);
        }

        public void PrimaryDirection(Vector3 direction)
        {
            action.PrimaryDirectionReaction(direction);
        }

        public void SecondAnalog(float intensity)
        {
            action.SecondAnalogReaction(intensity);
        }

        public void SecondaryDirection(Vector3 direction)
        {
            action.SecondaryDirectionReaction(direction);
        }

        public void SecondInput(bool isActive)
        {
            action.SecondReaction(isActive);
        }

        public void SixthInput(bool isActive)
        {
            action.SixthReaction(isActive);
        }

        public void ThirdDirection(Vector3 direction)
        {
            action.ThirdDirectionReaction(direction);
        }

        public void ThirdInput(bool isActive)
        {
            action.ThirdReaction(isActive);
        }

        public void WorldPositionInput(Vector3 worldPosition)
        {
            action.WorldReaction(worldPosition);
        }
    }
}
