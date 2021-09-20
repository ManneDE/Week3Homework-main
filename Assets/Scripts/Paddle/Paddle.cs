using UnityEngine;

public class Paddle : MonoBehaviour
{
    //TODO
    // Move paddle left and right using keyboard keys, mapping is up to you. DONE HERE!
    // Paddle should be able to launch the ball upon space bar being pressed. DONE IN MULTIPLE METHODS!
    // A launched ball will then bounce around, changing its direction upon any collision. DONE HERE!

    private float speed = 20.0f;

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }

        var xPosition = Mathf.Clamp(transform.position.x, -5.0f, 5.0f);
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
    }
}