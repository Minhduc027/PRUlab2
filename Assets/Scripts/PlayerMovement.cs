using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private float torqueAmount;
    [SerializeField] private Rigidbody2D playerRigidbody;
    [SerializeField] private Collider2D playerCollider2D;

    public void HandlePlayerMovement (PlayerMovementType movementType) {
        switch (movementType) {
            case PlayerMovementType.NONE:
            break;
            case PlayerMovementType.JUMP:
                HandleJumpMovement();
            break;
            case PlayerMovementType.ROTATE_LEFT:
                playerRigidbody.AddTorque(torqueAmount);
            break;

            case PlayerMovementType.ROTATE_RIGHT:
                playerRigidbody.AddTorque(-torqueAmount);
            break;
        }
    }

    private void HandleJumpMovement() {
        playerRigidbody.AddForce(new Vector2(0,100 * Time.deltaTime * jumpForce));
    }

}

public enum PlayerMovementType {
    NONE,
    JUMP,
    ROTATE_LEFT,
    ROTATE_RIGHT
}
