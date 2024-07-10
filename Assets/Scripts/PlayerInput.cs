using TMPro;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerMovementType movementType;

    private void Awake()
    {
        movementType = PlayerMovementType.NONE;
    }

    private void Update(){
        ReadPlayerInput();
    }

    private void ReadPlayerInput() {
        if(Input.GetKey(KeyCode.LeftArrow)){
            movementType = PlayerMovementType.ROTATE_LEFT;
            return;
        }else if (Input.GetKey(KeyCode.RightArrow)) {
            movementType = PlayerMovementType.ROTATE_RIGHT;
            return;
        }
        if (Input.GetKey(KeyCode.Space)) {
            movementType = PlayerMovementType.JUMP;
        }
    }
    public PlayerMovementType PlayerMovementType {get => movementType; set => movementType = value; }
}
