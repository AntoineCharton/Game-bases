using UnityEngine;
using GZ.PlayerInputs;

public class KeyboardInputs : InputBase
{
    bool isKeyboard = false;
    float verticalDirection = 0;
    float horizontalDirection = 0;
    PlayerInputPreferences PlayerInputPreferences;

    public override void UpdateInput()
    {
        if (PlayerInputPreferences == null)
            PlayerInputPreferences = new PlayerInputPreferences();

        if (Input.GetKey(PlayerInputPreferences.forward))
        {
            verticalDirection = 1;
        }
        else if (Input.GetKey(PlayerInputPreferences.backward))
        {
            verticalDirection = -1;
        } else
        {
            verticalDirection = 0;
        }

        if (Input.GetKey(PlayerInputPreferences.left))
        {
            horizontalDirection = -1;
        }
        else if (Input.GetKey(PlayerInputPreferences.right))
        {
            horizontalDirection = 1;
        }
        else
        {
            horizontalDirection = 0;
        }

        primaryDirection = new Vector3(horizontalDirection, 0, verticalDirection);

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            var screenToWorld = hit.point;
            worldPosition = screenToWorld;
        }

        if (Input.GetButtonDown("Cancel") || Input.GetKeyDown(PlayerInputPreferences.cancelInput))
        {
            cancelInput = true;
        }
        else
        {
            cancelInput = false;
        }

        if (Input.GetKeyDown(PlayerInputPreferences.firstSecondaryInput))
        {
            firstSecondaryInput = true;
        }
        else
        {
            firstSecondaryInput = false;
        }

        if (Input.GetKey(PlayerInputPreferences.fireInput) || Input.GetMouseButton(0))
        {
            fireInput = true;
        }
        else
        {
            fireInput = false;
        }

        if (Input.GetKey(PlayerInputPreferences.action))
        {
            actionInput = true;
        }
        else
        {
            actionInput = false;
        }

        if (Input.GetKey(KeyCode.Space))
            jumpInput = true;
        else
            jumpInput = false;

        if (Input.GetKey(PlayerInputPreferences.secondSecondaryInput) || Input.GetMouseButton(1))
        {
            secondSecondaryInput = true;
            enableWorldDirectionUpdate = true;
        } else
        {
            secondSecondaryInput = false;
            enableWorldDirectionUpdate = false;
        }

        if (Input.GetKeyDown(PlayerInputPreferences.thirdSecondaryInput))
        {
            thirdSecondaryInput = true;
        }
        else
        {
            thirdSecondaryInput = false;
        }

        if (Input.GetKeyDown(PlayerInputPreferences.fourthSecondaryInput))
        {
            fourthSecondaryInput = true;
        }
        else
        {
            fourthSecondaryInput = false;
        }
    }
}