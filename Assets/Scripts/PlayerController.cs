using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private PlayerMovement playerMovement;
    void Update()
    {
        var movementType = playerInput.PlayerMovementType;
        playerMovement.HandlePlayerMovement(movementType);
    }

}
