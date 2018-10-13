using UnityEngine;
using PlayerInputs;

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
        }
        else
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
        if (isKeyboard == true)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                var screenToWorld = hit.point;
                worldPosition = screenToWorld;
            }
        }

        if (Input.GetButtonDown("Cancel"))
        {
            sixthInput = true;
        }
        else
        {
            sixthInput = false;
        }

        if (Input.GetKeyDown(PlayerInputPreferences.thirdAction))
        {
            thirdInput = true;
        }
        else
        {
            thirdInput = false;
        }

        if (Input.GetMouseButton(1))
        {
            fifthInput = true;
        }
        else
        {
            fifthInput = false;
        }

        if (Input.GetKey(PlayerInputPreferences.secondAction) || Input.GetMouseButton(0))
        {
            secondInput = true;
        }
        else
        {
            secondInput = false;
        }

        if (Input.GetKey(PlayerInputPreferences.action))
        {
            firstInput = true;
        }
        else
        {
            firstInput = false;
        }

        if (Input.GetButton("Jump"))
            fourthInput = true;
        else
            fourthInput = false;
    }
}