using System.Collections.Generic;
using UnityEngine;

namespace GZ.PlayerInputs
{
    public class PlayerInputManager : MonoBehaviour
    {
        public List<InputObject> Receivers;
        // Use this for initialization
        void Awake()
        {
            foreach (var receiver in Receivers)
            {
                receiver.InitializeReceiver();
            }
        }

        void Update()
        {
            foreach (var receiver in Receivers)
            {
                if (receiver.isEnabled)
                    receiver.UpdateReceiver();
            }
        }

        public void SwitchAllInputs(string inputType)
        {
            foreach (var receiver in Receivers)
            {
                receiver.InputType = inputType;
                receiver.InitializeReceiver();
            }
        }

        public void DisableInputByTag(string tag)
        {
            foreach (var receiver in Receivers)
            {
                if (receiver.id == tag)
                    receiver.isEnabled = false;
            }
        }
        public void EnableInputByTag(string tag)
        {
            foreach (var receiver in Receivers)
            {
                if (receiver.id == tag)
                    receiver.isEnabled = true;
            }
        }

        public void AddReceiver(GameObject receiver, string id)
        {
            Receivers.Add(new InputObject(receiver, id));
        }
    }
}