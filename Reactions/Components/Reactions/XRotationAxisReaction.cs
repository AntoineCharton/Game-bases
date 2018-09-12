using UnityEngine;

public class XRotationAxisReaction : ReactionBehaviour, IReactions
{
    public float rotationSpeed = 10f;
    public float maxUp = -80f;
    public float maxDown = 80f;


    public override void SecondaryDirectionReaction(Vector3 direction)
    {
        var eulerRotation = transform.localEulerAngles;
        var targetRotation = eulerRotation.x + (-direction.z * rotationSpeed * Time.deltaTime);
        targetRotation = (targetRotation > 180) ? targetRotation - 360 : targetRotation;
        
        if (targetRotation > maxUp && targetRotation < maxDown)
            transform.localRotation = Quaternion.Euler(targetRotation, eulerRotation.y, eulerRotation.z);
    }
}
