using System;
using UnityEngine;

namespace Reactions {
    public class GameInputToReactionsReceiver : MonoBehaviour, IGameInputReceiver {
        private IReactions action;

        
        private void Awake () {
            action = GetComponent<IReactions> ();
        }

        public void Speed(Vector3 Speed)
        {
            action.PrimaryDirectionReaction(Speed);
        }


    }
}