using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public Transform player;
    public Rigidbody rb;
    [SerializeField] private float moveInput;
    public float speed;

    [SerializeField] private Vector2 _direction;
    public float speedDown;
    public bool isMoveDown;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (isMoveDown == true)
        {
            _direction.y = -1;
            transform.Translate(_direction * speedDown * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, 0);
    }
}
