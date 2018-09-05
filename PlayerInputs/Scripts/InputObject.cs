using UnityEngine;
using System.Collections.Generic;

namespace PlayerInputs
{

    [System.Serializable]
    public class InputObject
    {
        public GameObject ControllableObject;
        public string InputType;
        private List<Receiver> receivers;
        private InputBase inputScript;
        private bool isInitialized = false;

        public void InitializeReceiver()
        {

            inputScript = (InputBase)ReflectionUtils.createObject(InputType);
            var ICharacterComponents = ControllableObject.GetComponentsInChildren<IInputReceiver>();
            receivers = new List<Receiver>();
            foreach (var component in ICharacterComponents)
            {
                var receiver = new Receiver(component);
                receivers.Add(receiver);
            }

            isInitialized = true;
        }

        public bool IsInitialized()
        {
            return isInitialized;
        }

        public void UpdateReceiver()
        {
            inputScript.UpdateInput();
            foreach (var receiver in receivers)
            {
                receiver.PrimaryDirection(inputScript.GetPrimaryDirection());

                if (inputScript.GetSecondaryDirection() != Vector3.zero)
                    receiver.SecondaryDirection(inputScript.GetSecondaryDirection());

                receiver.ThirdInput(inputScript.GetIsThirdInput());
                receiver.FirstInput(inputScript.GetIsFirstInput());

                if (inputScript.IsWorldDirectionEnabled())
                    receiver.WorldPositionInput(inputScript.GetWorldPosition());
            }
        }
    }
}