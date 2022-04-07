using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class MovementPlayer : MonoBehaviour
{
    [Header("Movement vars")]
    [SerializeField] private float jumpForce;
    [SerializeField] private bool isGround;
    [SerializeField] private float speed;

    [Header("Another settings")]
    [SerializeField] private Transform GroundColliderTransform;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float JumpFactor;
    [SerializeField] private LayerMask GroundMask;
    public Animator anim;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        Vector3 OverLapCircklePosition = GroundColliderTransform.position;
        isGround = Physics2D.OverlapCircle(OverLapCircklePosition, JumpFactor, GroundMask);
    }
    public void Move(float direction, bool Jumpis)
    {
        if (Jumpis)
        {
            anim.SetBool("isJump", true);
            Jump();
        }
        if (Mathf.Abs(direction) > 0.01f)
        {
            HorizontalMovement(direction);
        }
    }
    private void Jump()
    {
        if (isGround)
        {            
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    private void Update()
    {
    }
    private void HorizontalMovement(float direction)
    {
        rb.velocity = new Vector2(curve.Evaluate(direction), rb.velocity.y);
        sprite.flipX = direction < 0f;
    }
}
