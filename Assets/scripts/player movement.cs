using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
    
{
    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    public GameObject Player;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;
        DontDestroyOnLoad(Player);
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
