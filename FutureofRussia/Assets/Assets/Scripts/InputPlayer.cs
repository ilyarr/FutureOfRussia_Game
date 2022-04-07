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
        bool JumpIs = Input.GetButtonDown(StringConstants.JUMP);
        movement.Move(HorizontalMovement, JumpIs);

        //movement.anim.SetBool("isJump", false);

        movement.anim.SetBool("isRun", Mathf.Abs(HorizontalMovement)>0f);

    }
}
