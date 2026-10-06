using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private void Update()
    {
        Vector3 direction = Vector3.zero;

        // Up and down
        if (Keyboard.current.upArrowKey.isPressed)
        {
            direction.z += 1;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            direction.z -= 1;
        }

        // Right Left
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            direction.x += 1;
        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            direction.x -= 1;
        }

        // Movement
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
