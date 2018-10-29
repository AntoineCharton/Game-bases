using System;
using UnityEngine;

namespace GZ.Reactions {
    public abstract class ReactionBehaviour : MonoBehaviour {
        public virtual void FifthReaction (bool isActive) {
            throw new NotImplementedException ();
        }

        public virtual void FirstAnalogReaction (float intensity) {
            throw new NotImplementedException ();
        }

        public virtual void FirstReaction (bool isActive) {
            throw new NotImplementedException ();
        }

        public virtual void FourthReaction (bool isActive) {
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

        public virtual void SecondReaction (bool isActive) {
            throw new NotImplementedException ();
        }

        public virtual void SixthReaction (bool isActive) {
            throw new NotImplementedException ();
        }

        public virtual void ThirdDirectionReaction (Vector3 direction) {
            throw new NotImplementedException ();
        }

        public virtual void ThirdReaction (bool isActive) {
            throw new NotImplementedException ();
        }

        public virtual void WorldReaction (Vector3 position) {
            throw new NotImplementedException ();
        }
    }
}