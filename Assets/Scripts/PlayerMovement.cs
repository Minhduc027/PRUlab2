using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private float torqueAmount;
    [SerializeField] private Rigidbody2D playerRigidbody;

    public void HandlePlayerMovement (PlayerMovementType movementType) {
        switch (movementType) {
            case PlayerMovementType.NONE:
            break;
            case PlayerMovementType.JUMP:
                playerRigidbody.AddForce(new Vector2(0,1000 * Time.deltaTime * jumpForce));
            break;
            case PlayerMovementType.ROTATE_LEFT:
                
            break;

            case PlayerMovementType.ROTATE_RIGHT:

            break;
        }
    }

}

public enum PlayerMovementType {
    NONE,
    JUMP,
    ROTATE_LEFT,
    ROTATE_RIGHT
}
