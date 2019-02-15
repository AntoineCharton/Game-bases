using UnityEngine;
using System.Collections.Generic;
using GZ.Reflection;

namespace GZ.PlayerInputs
{

    [System.Serializable]
    public class InputObject
    {
        public GameObject ControllableObject;
        public string InputType;
        public bool isEnabled = true;
        public string id = "";
        private List<Receiver> receivers;
        private InputBase inputScript;
        private bool isInitialized = false;

        public InputObject()
        {

        }

        public InputObject(GameObject gameObject, string _id)
        {
            ControllableObject = gameObject;
            id = _id;
            InputType = "UnityInputPlayerOne";
            InitializeReceiver();
        }

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

                receiver.FirstSecondaryInput(inputScript.GetIsFirstSecondaryInput());
                receiver.ActionInput(inputScript.GetIsActionInput());
                receiver.FireInput(inputScript.GetIsFireInput());
                receiver.JumpInput(inputScript.GetIsJumpInput());
                receiver.SecondSecondaryInput(inputScript.GetIsSecondSecondaryInput());
                receiver.ThirdSecondaryInput(inputScript.GetIsThirdSecondaryInput());
                receiver.FourthSecondaryInput(inputScript.GetIsFourthSecondaryInput());
                receiver.CancelInput(inputScript.GetIsCancelInput());
                if (inputScript.IsWorldDirectionEnabled())
                    receiver.WorldPositionInput(inputScript.GetWorldPosition());
            }
        }
    }
}