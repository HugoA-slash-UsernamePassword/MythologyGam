using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls controls = new PlayerControls();

    private float movement;
    
    void Start()
    {
        controls.PlayerControls.Jump.performed += ctx => Jump();

        controls.PlayerControls.Movement.performed += ctx => movement = ctx.ReadValue<float>();
        controls.PlayerControls.Movement.performed += ctx => movement = 0;
    }

    private void Update() {
        Move();
    }

    private void Jump() {
        
    }

    private void Move()
    {
        
    }

    private bool CheckCollisions(Vector2 direction) {
        // Raycast in direction of movement

        RaycastHit hit;

        if (Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity)) {
            
        }
    }
}
