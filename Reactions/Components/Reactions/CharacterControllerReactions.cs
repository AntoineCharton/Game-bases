using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterControllerReactions : MonoBehaviour, IReactions
{
    public enum RotationType { LookAt, Rotate };
    public enum MoveDirection { Forward, World };

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float rotationSpeed = 10f;
    public MoveDirection DirectionType = MoveDirection.Forward;
    public RotationType RotateType = RotationType.LookAt;
    private Vector3 moveDirection = Vector3.zero;
    private bool isJumping = false;
    private bool receivedLookAt = false;
    CharacterController controller;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            if (DirectionType == MoveDirection.Forward)
            {
                moveDirection = transform.TransformDirection(moveDirection);
            }

            moveDirection *= speed;
            if (isJumping)
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

    }

    void LateUpdate()
    {
        receivedLookAt = false;
    }

    void Jump(bool isActive)
    {
        isJumping = isActive;
    }

    void Move(Vector3 direction)
    {
        if (controller.isGrounded)
            moveDirection = new Vector3(direction.x, 0, direction.z);
    }

    void Rotate(Vector3 direction)
    {
        var eulerRotation = transform.rotation.eulerAngles;
        if (RotateType == RotationType.LookAt && receivedLookAt == false)
        {
            var atan2 = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(eulerRotation.x, (atan2), eulerRotation.z ), rotationSpeed * Time.deltaTime);
        }
        else if (RotateType == RotationType.Rotate)
        {
            transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y + (direction.x *  rotationSpeed * Time.deltaTime), eulerRotation.z );
        }
    }

    void LookAt(Vector3 position)
    {
        if (RotateType == RotationType.LookAt)
        {
            receivedLookAt = true;
            var lookPos = position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
        }
    }

    public void PrimaryDirectionReaction(Vector3 direction)
    {
        Move(direction);
    }

    public void SecondaryDirectionReaction(Vector3 direction)
    {
        Rotate(direction);
    }

    public void ThirdDirectionReaction(Vector3 direction)
    {
        throw new NotImplementedException();
    }

    public void FirstAnalogReaction(float intensity)
    {
        throw new NotImplementedException();
    }

    public void SecondAnalogReaction(float intensity)
    {
        throw new NotImplementedException();
    }

    public void FirstReaction(bool isActive) { }

    public void SecondReaction(bool isActive)
    {
        throw new NotImplementedException();
    }

    public void ThirdReaction(bool isActive)
    {
        Jump(isActive);
    }

    public void FourthReaction(bool isActive)
    {
        throw new NotImplementedException();
    }

    public void FifthReaction(bool isActive)
    {
        throw new NotImplementedException();
    }

    public void SixthReaction(bool isActive)
    {
        throw new NotImplementedException();
    }

    public void WorldReaction(Vector3 position)
    {
        LookAt(position);
    }
}