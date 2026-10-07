using UnityEngine;
using UnityEngine.InputSystem;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float rSpeed = 100f;

    private void Update()
    {
        Vector3 direction = Vector3.zero;

        // Up Down
        if (Keyboard.current.wKey.isPressed)
        {
            direction.z += 1;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            direction.z -= 1;
        }

        // Right Left
        if (Keyboard.current.dKey.isPressed)
        {
            direction.x += 1;
        }
        else if(Keyboard.current.aKey.isPressed)
        {
            direction.x -= 1;
        }

        // Movement
        transform.Translate(direction.normalized * speed * Time.deltaTime);


        // Rotation Left Right
        if (Keyboard.current.qKey.isPressed)
        {
            transform.Rotate(0, -rSpeed * Time.deltaTime, 0);
        }

        if (Keyboard.current.eKey.isPressed)
        {
            transform.Rotate(0, rSpeed * Time.deltaTime, 0);
        }
    }

    private void LateUpdate()
    {
        // Reference: https://docs.unity.com/en-us/engine/6000.6/script-reference/unityengine/terrain/sampleheight
        // Getting the terrain
        Terrain terrain = Terrain.activeTerrain;

        Vector3 pos = transform.position;

        // Keeping the cube on the terrain
        pos.y = 
            // terrain height
            terrain.transform.position.y 
            // add terrain's Y position
            + terrain.SampleHeight(transform.position)
            // add half of the cube's height
            + transform.localScale.y / 2f;

        transform.position = pos;
    }
}
