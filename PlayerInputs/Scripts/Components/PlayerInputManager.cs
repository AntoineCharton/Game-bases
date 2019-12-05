using System.Collections.Generic;
using UnityEngine;
using GZ.Reflection;

namespace GZ.PlayerInputs
{
    public class PlayerInputManager : MonoBehaviour
    {
        public string defaultInputType;
        public List<InputObject> Receivers;
        // Use this for initialization
        void Awake()
        {
            InitializeReceiver();
            if (defaultInputType == "")
            {
                var inheritedObjects = ReflectionUtils.GetEnumerableOfType<InputBase>(null);
                defaultInputType = inheritedObjects[0];
            }
            SwitchAllInputs(defaultInputType);
        }

        public void InitializeReceiver()
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
            defaultInputType = inputType;
            foreach (var receiver in Receivers)
            {
                receiver.InputType = inputType;
                receiver.InitializeReceiver();
            }
        }

        public void DisableAllInputs()
        {
            foreach (var receiver in Receivers)
            {
                receiver.isEnabled = false;
            }
        }

        public void EnableAllInputs()
        {
            foreach (var receiver in Receivers)
            {
                receiver.isEnabled = true;
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
            var newReceiver = new InputObject(receiver, id);
            newReceiver.InputType = defaultInputType;
            Receivers.Add(newReceiver);
            InitializeReceiver();
        }


        public void RemoveReceiver(string id)
        {
            foreach(var receiver in Receivers)
            {
                if (receiver.id == tag)
                    Receivers.Remove(receiver);
            }
        }
    }
}