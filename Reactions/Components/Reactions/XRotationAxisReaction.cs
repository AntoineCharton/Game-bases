using UnityEngine;

public class XRotationAxisReaction : MonoBehaviour, IReactions
{
    public float rotationSpeed = 10f;
    public float maxUp = -80f;
    public float maxDown = 80f;

    public void FifthReaction(bool isActive)
    {

    }

    public void FirstAnalogReaction(float intensity)
    {

    }

    public void FirstReaction(bool isActive)
    {
    }

    public void FourthReaction(bool isActive)
    {

    }

    public void PrimaryDirectionReaction(Vector3 direction)
    {
    }

    public void SecondAnalogReaction(float intensity)
    {

    }

    public void SecondaryDirectionReaction(Vector3 direction)
    {
        var eulerRotation = transform.localEulerAngles;
        var targetRotation = eulerRotation.x + (-direction.z * rotationSpeed * Time.deltaTime);
        targetRotation = (targetRotation > 180) ? targetRotation - 360 : targetRotation;
        
        if (targetRotation > maxUp && targetRotation < maxDown)
            transform.localRotation = Quaternion.Euler(targetRotation, eulerRotation.y, eulerRotation.z);
    }

    public void SecondReaction(bool isActive)
    {
    }

    public void SixthReaction(bool isActive)
    {
    }

    public void ThirdDirectionReaction(Vector3 direction)
    {
    }

    public void ThirdReaction(bool isActive)
    {
    }

    public void WorldReaction(Vector3 position)
    {
    }

}
