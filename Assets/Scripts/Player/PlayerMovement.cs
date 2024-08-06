using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float playerSpeed;
    [SerializeField]private float jumpForce;
    [SerializeField]private float gravity;
    [SerializeField]private ParticleSystem particleMovement;
    [SerializeField]private Transform particleMovementPosition;

    private CharacterController controller;
    private Vector3 direction;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        if (controller.isGrounded)
        {
            direction = new Vector3(horizontal, 0, 0).normalized;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                direction.y = jumpForce;
            }
        }

        direction.y += gravity * Time.deltaTime;
        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * playerSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            Instantiate(particleMovement, particleMovementPosition);
        }
    }
}