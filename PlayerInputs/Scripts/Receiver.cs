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
        bool FirstInputImplemented = true;
        bool SecondInputImplemented = true;
        bool ThirdInputImplemented = true;
        bool FourthInputImplemented = true;
        bool FifthInputImplemented = true;
        bool SixthInputImplemented = true;
        bool WorldPositionInputImplemented = true;

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

        public void FirstInput(bool isActive)
        {
            if (FirstInputImplemented == false)
                return;

            try
            {
                receiver.FirstInput(isActive);
            }
            catch (NotImplementedException)
            {
                FirstInputImplemented = false;
            }
        }

        public void SecondInput(bool isActive)
        {
            if (SecondInputImplemented == false)
                return;

            try
            {
                receiver.SecondInput(isActive);
            }
            catch (NotImplementedException)
            {
                SecondInputImplemented = false;
            }
        }

        public void ThirdInput(bool isActive)
        {
            if (ThirdInputImplemented == false)
                return;

            try
            {
                receiver.ThirdInput(isActive);
            }
            catch (NotImplementedException)
            {
                ThirdInputImplemented = false;
            }
        }

        public void FourthInput(bool isActive)
        {
            if (FourthInputImplemented == false)
                return;

            try
            {
                receiver.FourthInput(isActive);
            }
            catch (NotImplementedException)
            {
                FourthInputImplemented = false;
            }
        }

        public void FifthInput(bool isActive)
        {
            if (FifthInputImplemented == false)
                return;

            try
            {
                receiver.FifthInput(isActive);
            }
            catch (NotImplementedException)
            {
                FifthInputImplemented = false;
            }
        }

        public void SixthInput(bool isActive)
        {
            if (SixthInputImplemented == false)
                return;

            try
            {
                receiver.SixthInput(isActive);
            }
            catch (NotImplementedException)
            {
                SixthInputImplemented = false;
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