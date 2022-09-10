using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls controls;

    float direction = 0;
    public float speedFat;
    public float speed = 400;
    public float scalSpeed = 1f;

    public static bool isTouched = false;
    public bool isFacingRight = true;

    public float jumpForce = 5;
    bool isGrounded;
    int numberOfJumps = 0;
    public Transform groundCheck;
    public LayerMask groundLayer;

    public Rigidbody2D playerRB;
    public Animator animator;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();

        controls.Land.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };

        controls.Land.Jump.performed += ctx => Jump();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        animator.SetBool("isGrounded", isGrounded);

        playerRB.velocity = new Vector2(direction * speed * Time.fixedDeltaTime, playerRB.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(direction));

        if (isFacingRight && direction < 0 || !isFacingRight && direction >0 )
            Flip();
        if (isTouched && speed > 0)
        {
            transform.localScale = new Vector3(
                transform.localScale.x + 0.2f * scalSpeed,
                transform.localScale.y + 0.2f * scalSpeed,
                0);
            speedFat = 100f;
            speed = speed -  0.1f * speedFat;
            isTouched = false;
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
    }

    void Jump()
    {
        if (isGrounded)
        {
            numberOfJumps = 0;
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
            numberOfJumps++;
            AudioManager.instance.Play("FirstJump");
        }
        else
        {
            if(numberOfJumps == 1)
            {
                playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
                numberOfJumps++;
                AudioManager.instance.Play("SecondJump");
            }
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
}