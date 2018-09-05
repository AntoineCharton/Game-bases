using UnityEngine;
using PlayerInputs;

public class UnityInputPlayerOne : InputBase
{

    bool isKeyboard = false;
    public override void UpdateInput()
    {
        primaryDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (isKeyboard)
        {
            enableWorldDirectionUpdate = true;
        }
        else
        {
            enableWorldDirectionUpdate = false;
        }

        if (Input.GetAxis("Mouse X") > 0 || Input.GetAxis("Mouse Y") > 0)
        {
            isKeyboard = true;
        }
        else if (Input.GetAxis("SecondaryHorizontal") != 0 || Input.GetAxis("SecondaryVertical") != 0)
        {
            isKeyboard = false;
        }

        if (isKeyboard == true)
        {
            secondaryDirection = new Vector3(Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y"));
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                var screenToWorld = hit.point;
                worldPosition = screenToWorld;
            }
        }
        else
        {
            secondaryDirection = new Vector3(Input.GetAxis("SecondaryHorizontal"), 0, Input.GetAxis("SecondaryVertical"));
        }

        if(Input.GetButton("Fire1")) {
            firstInput = true;
        }  else 
        {
            firstInput = false;
        }

        if (Input.GetButton("Jump"))
            thirdInput = true;
        else
            thirdInput = false;
    }
}