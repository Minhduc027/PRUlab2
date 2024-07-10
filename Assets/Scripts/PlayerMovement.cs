using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private float torqueAmount;
    [SerializeField] private Rigidbody2D playerRigidbody;
    [SerializeField] private CapsuleCollider2D playerBoard;
    [SerializeField] private LayerMask layer;

    public void HandlePlayerMovement (PlayerMovementType movementType) {
        Debug.DrawRay(playerBoard.bounds.center, Vector2.down * (playerBoard.bounds.extents.y + 0.1f));
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
        PlayerController.Instance.PlayerInput.PlayerMovementType = PlayerMovementType.NONE;
    }

    private void HandleJumpMovement() {
        var isGround = CheckGround();
        if (isGround) {
            playerRigidbody.AddForce(new Vector2(0,100 * Time.deltaTime * jumpForce));
        }
    }

    private bool CheckGround() {
        var rayHit = Physics2D.Raycast(playerBoard.bounds.center, Vector2.down, playerBoard.bounds.extents.y + 0.1f, layer);
        return rayHit.collider != null;
    }

}

public enum PlayerMovementType {
    NONE,
    JUMP,
    ROTATE_LEFT,
    ROTATE_RIGHT
}
