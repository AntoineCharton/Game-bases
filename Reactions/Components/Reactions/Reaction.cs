using System;
using UnityEngine;

namespace GZ.Reactions {
    public abstract class ReactionBehaviour : MonoBehaviour {
        public virtual void SecondSecondaryReaction (bool isActive) {
            throw new NotImplementedException ();
        }

        public virtual void FirstAnalogReaction (float intensity) {
            throw new NotImplementedException ();
        }

        public virtual void ActionReaction (bool isActive) {
            throw new NotImplementedException ();
        }

        public virtual void JumpReaction (bool isActive) {
            throw new NotImplementedException ();
        }

        public virtual void PrimaryDirectionReaction (Vector3 direction) {
            throw new NotImplementedException ();
        }

        public virtual void SecondAnalogReaction (float intensity) {
            throw new NotImplementedException ();
        }

        public virtual void SecondaryDirectionReaction (Vector3 direction) {
            throw new NotImplementedException ();
        }

        public virtual void FireReaction (bool isActive) {
            throw new NotImplementedException ();
        }

        public virtual void ThirdSecondaryReaction (bool isActive) {
            throw new NotImplementedException ();
        }

        public virtual void FourthSecondaryReaction(bool isActive)
        {
            throw new NotImplementedException();
        }

        public virtual void FifthSecondaryReaction(bool isActive)
        {
            throw new NotImplementedException();
        }

        public virtual void ThirdDirectionReaction (Vector3 direction) {
            throw new NotImplementedException ();
        }

        public virtual void FirstSecondaryReaction (bool isActive) {
            throw new NotImplementedException ();
        }

        public virtual void WorldReaction (Vector3 position) {
            throw new NotImplementedException ();
        }

        public virtual void CancelReaction(bool isActive)
        {
            throw new NotImplementedException();
        }

    }
}