using UnityEngine;

namespace PlayerInputs
{
    public abstract class InputBase : UnityEngine.Object
    {
        protected Vector3 primaryDirection;
        protected Vector3 secondaryDirection;
        protected bool firstInput = false;
        protected bool secondInput = false;
        protected bool thirdInput = false;
        protected bool fourthInput = false;
        protected bool fifthInput = false;
        protected bool sixthInput = false;
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

        public bool GetIsFirstInput()
        {
            return firstInput;
        }

        public bool GetIsSecondInput()
        {
            return secondInput;
        }
        public bool GetIsThirdInput()
        {
            return thirdInput;
        }
        public bool GetIsFourthInput()
        {
            return fourthInput;
        }

        public bool GetIsFifthInput()
        {
            return fifthInput;
        }

        public bool GetIsSixthInput()
        {
            return sixthInput;
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
