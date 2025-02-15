using UnityEngine;

public class rotation_front : MonoBehaviour
{
    private Vector2 moveDirection;
    private float targetAngle;

    void Update()
    {
        // Get input values
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // Calculate move direction
        moveDirection = new Vector2(horizontal, vertical).normalized;

        // Only rotate if there's movement input
        if (moveDirection != Vector2.zero)
        {
            // Calculate the angle between Vector2.up and movement direction
            targetAngle = Vector2.SignedAngle(Vector2.up, moveDirection);
            
            // Apply rotation while keeping the forward vector (z-axis) unchanged
            transform.rotation = Quaternion.Euler(0, 0, targetAngle);
        }
    }
}
