using UnityEngine;
using GZ.Utils;
public class CharacterAnimationController : MonoBehaviour
{
    public Animator Animator;
    public IGroundableObject GroundableObject;
    public float LongIdleTime = 5;
    Vector3 lastPosition = Vector3.zero;

    private float idleTimer = 0;
    void Start()
    {
        GroundableObject = GetComponent<IGroundableObject>() as IGroundableObject;
    }

    // Update is called once per frame
    void Update()
    {
        var speed = (transform.position - lastPosition).magnitude;
        if (speed != 0)
            speed /= Time.deltaTime;
        lastPosition = transform.position;
        Animator.SetFloat("Speed", speed * 10);

        if (speed > 0 && GroundableObject.IsGrounded())
        {
            Animator.SetBool("IsLongIdle", false);
            idleTimer = 0;
        }
        else
            idleTimer += Time.deltaTime;

        if (idleTimer > LongIdleTime)
            Animator.SetBool("IsLongIdle", true);

        if (GroundableObject.IsGrounded())
            Animator.SetBool("IsGrounded", true);
        else
            Animator.SetBool("IsGrounded", false);
    }
}
