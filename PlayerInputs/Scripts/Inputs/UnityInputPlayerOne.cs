using UnityEngine;
using GZ.PlayerInputs;

public class UnityInputPlayerOne : InputBase
{

    bool isKeyboard = false;
    public override void UpdateInput()
    {
        primaryDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        secondaryDirection = new Vector3(Input.GetAxis("SecondaryHorizontal"), 0, Input.GetAxis("SecondaryVertical"));

        if(secondaryDirection != Vector3.zero)
        {
            secondSecondaryInput = true;
        } else
        {
            secondSecondaryInput = false;
        }

        if (isKeyboard)
        {
            enableWorldDirectionUpdate = true;
        }
        else
        {
            enableWorldDirectionUpdate = false;
        }

        if(Input.GetButtonDown("Cancel")) {
            cancelInput = true;
        } else {
            cancelInput = false;
        }

        if (Input.GetButton("Fire3"))
        {
            firstSecondaryInput = true;
        }
        else
        {
            firstSecondaryInput = false;
        }

        if (Input.GetButtonDown("RightButton"))
        {
            fourthSecondaryInput = true;
        }
        else
        {
            fourthSecondaryInput = false;
        }

        if (Input.GetButtonDown("LeftButton"))
        {
            thirdSecondaryInput = true;
        }
        else
        {
            thirdSecondaryInput = false;
        }

        if (Input.GetButtonDown("Fire2") || Input.GetAxis("FireTrigger") < - 0.5f)
        {
            fireInput = true;
        }
        else
        {
            fireInput = false;
        }

        if (Input.GetButton("Fire1"))
        {
            actionInput = true;
        }
        else
        {
            actionInput = false;
        }

        if (Input.GetButton("Jump"))
            jumpInput = true;
        else
            jumpInput = false;
    }
}