using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 inputVector;

    void Update()
    {
        // Read input from keyboard
        inputVector = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
            inputVector.y += 1;
        if (Keyboard.current.sKey.isPressed)
            inputVector.y -= 1;
        if (Keyboard.current.aKey.isPressed)
            inputVector.x -= 1;
        if (Keyboard.current.dKey.isPressed)
            inputVector.x += 1;

        Vector3 movement = new Vector3(inputVector.x, 0, inputVector.y).normalized;

        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}

