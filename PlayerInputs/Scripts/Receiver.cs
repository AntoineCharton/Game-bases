using System;
using UnityEngine;

namespace GZ.PlayerInputs
{
    public class Receiver : IInputReceiver
    {
        public IInputReceiver receiver;
        bool PrimaryDirectionImplemented = true;
        bool SecondaryDirectionImplemented = true;
        bool ThirdDirectionImplemented = true;
        bool FirstAnalogImplemented = true;
        bool SecondAnalogImplemented = true;
        bool ActionInputImplemented = true;
        bool FireInputImplemented = true;
        bool FirstSecondaryInputInplemented = true;
        bool JumpInputImplemented = true;
        bool SecondSecondaryInputImplemented = true;
        bool ThirdSecondaryInputImplemented = true;
        bool FourthSecondaryInputImplemented = true;
        bool WorldPositionInputImplemented = true;
        bool CancelInputInplemented = true;

        public Receiver(IInputReceiver _receiver)
        {
            receiver = _receiver;
        }

        public void PrimaryDirection(Vector3 direction)
        {
            if (PrimaryDirectionImplemented == false)
                return;

            try
            {
                receiver.PrimaryDirection(direction);
            }
            catch (NotImplementedException)
            {
                PrimaryDirectionImplemented = false;
            }
        }

        public void SecondaryDirection(Vector3 direction)
        {
            if (SecondaryDirectionImplemented == false)
                return;

            try
            {
                receiver.SecondaryDirection(direction);
            }
            catch (NotImplementedException)
            {
                SecondaryDirectionImplemented = false;
            }
        }

        public void ThirdDirection(Vector3 direction)
        {
            if (ThirdDirectionImplemented == false)
                return;

            try
            {
                receiver.ThirdDirection(direction);
            }
            catch (NotImplementedException)
            {
                ThirdDirectionImplemented = false;
            }
        }

        public void FirstAnalog(float intensity)
        {
            if (FirstAnalogImplemented == false)
                return;

            try
            {
                receiver.FirstAnalog(intensity);
            }
            catch (NotImplementedException)
            {
                FirstAnalogImplemented = false;
            }
        }

        public void SecondAnalog(float intensity)
        {
            if (SecondAnalogImplemented == false)
                return;

            try
            {
                receiver.SecondAnalog(intensity);
            }
            catch (NotImplementedException)
            {
                SecondAnalogImplemented = false;
            }
        }

        public void ActionInput(bool isActive)
        {
            if (ActionInputImplemented == false)
                return;

            try
            {
                receiver.ActionInput(isActive);
            }
            catch (NotImplementedException)
            {
                ActionInputImplemented = false;
            }
        }

        public void FireInput(bool isActive)
        {
            if (FireInputImplemented == false)
                return;

            try
            {
                receiver.FireInput(isActive);
            }
            catch (NotImplementedException)
            {
                FireInputImplemented = false;
            }
        }

        public void FirstSecondaryInput(bool isActive)
        {
            if (FirstSecondaryInputInplemented == false)
                return;

            try
            {
                receiver.FirstSecondaryInput(isActive);
            }
            catch (NotImplementedException)
            {
                FirstSecondaryInputInplemented = false;
            }
        }

        public void JumpInput(bool isActive)
        {
            if (JumpInputImplemented == false)
                return;

            try
            {
                receiver.JumpInput(isActive);
            }
            catch (NotImplementedException)
            {
                JumpInputImplemented = false;
            }
        }

        public void SecondSecondaryInput(bool isActive)
        {
            if (SecondSecondaryInputImplemented == false)
                return;

            try
            {
                receiver.SecondSecondaryInput(isActive);
            }
            catch (NotImplementedException)
            {
                SecondSecondaryInputImplemented = false;
            }
        }

        public void ThirdSecondaryInput(bool isActive)
        {
            if (ThirdSecondaryInputImplemented == false)
                return;

            try
            {
                receiver.ThirdSecondaryInput(isActive);
            }
            catch (NotImplementedException)
            {
                ThirdSecondaryInputImplemented = false;
            }
        }

        public void FourthSecondaryInput(bool isActive)
        {
            if (FourthSecondaryInputImplemented == false)
                return;

            try
            {
                receiver.FourthSecondaryInput(isActive);
            }
            catch (NotImplementedException)
            {
                FourthSecondaryInputImplemented = false;
            }
        }

        public void CancelInput(bool isActive)
        {
            if (CancelInputInplemented == false)
                return;

            try
            {
                receiver.CancelInput(isActive);
            }
            catch (NotImplementedException)
            {
                CancelInputInplemented = false;
            }
        }



        public void WorldPositionInput(Vector3 worldPositionInput)
        {
            if (WorldPositionInputImplemented == false)
                return;

            try
            {
                receiver.WorldPositionInput(worldPositionInput);
            }
            catch (NotImplementedException)
            {
                WorldPositionInputImplemented = false;
            }
        }
    }
}