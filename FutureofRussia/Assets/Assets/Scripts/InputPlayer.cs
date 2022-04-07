using UnityEngine;

[RequireComponent(typeof(MovementPlayer))]
public class InputPlayer : MonoBehaviour
{
    private MovementPlayer movement;
    private void Awake()
    {
        movement = GetComponent<MovementPlayer>();
    }
    private void Update()
    {
        float HorizontalMovement = Input.GetAxis(StringConstants.HORIZONTAL_AXIS);
        bool IsJump = Input.GetButtonDown(StringConstants.JUMP);
        movement.Move(HorizontalMovement, IsJump);
        movement.anim.SetBool("isRun", Mathf.Abs(HorizontalMovement)>0f);

    }
}
