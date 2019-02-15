using UnityEngine;

namespace GZ.PlayerInputs
{
    public abstract class InputBase : UnityEngine.Object
    {
        protected Vector3 primaryDirection;
        protected Vector3 secondaryDirection;
        protected bool firstSecondaryInput = false;
        protected bool secondSecondaryInput = false;
        protected bool thirdSecondaryInput = false;
        protected bool fourthSecondaryInput = false;
        protected bool actionInput = false;
        protected bool fireInput = false;
        protected bool cancelInput = false;
        protected bool jumpInput = false;
        protected Vector3 worldPosition;
        protected bool enableWorldDirectionUpdate = false;
        private Vector3 returnedPrimaryDirection;
        private Vector3 returnedSecondaryDirection;

        abstract public void UpdateInput();

        public Vector3 GetPrimaryDirection()
        {
            returnedPrimaryDirection = primaryDirection;
            return returnedPrimaryDirection;
        }

        public Vector3 GetSecondaryDirection()
        {
            var returnedDirection = secondaryDirection;
            return returnedSecondaryDirection;
        }

        public bool GetIsCancelInput()
        {
            return cancelInput;
        }

        public bool GetIsActionInput()
        {
            return actionInput;
        }

        public bool GetIsFireInput()
        {
            return fireInput;
        }

        public bool GetIsJumpInput()
        {
            return jumpInput;
        }

        public bool GetIsFirstSecondaryInput()
        {
            return firstSecondaryInput;
        }

        public bool GetIsSecondSecondaryInput()
        {
            return secondSecondaryInput;
        }

        public bool GetIsThirdSecondaryInput()
        {
            return thirdSecondaryInput;
        }

        public bool GetIsFourthSecondaryInput()
        {
            return fourthSecondaryInput;
        }

        public Vector3 GetWorldPosition()
        {
            return worldPosition;
        }

        public bool IsWorldDirectionEnabled()
        {
            return enableWorldDirectionUpdate;
        }
    }
}
