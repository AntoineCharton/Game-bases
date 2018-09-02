using System.Collections.Generic;
using UnityEngine;

namespace PlayerInputs
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
                receiver.UpdateReceiver();
            }
        }
    }
}
