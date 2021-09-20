using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody = null;

    public bool released = false;

    //TODO
    //Add code to move ball along with code to delete pieces upon colliding with one. DONE IN OTHER METHOD!
    //Ball should only move once its been launched. DONE IN MULTIPLE METHODS!

    private float speed = 10.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && released == false)
        {
            Respawn();
            released = true;
        }
    }

    void Start()
    {
        //Respawn();
    }

    public void Respawn()
    {
        transform.position = Vector3.zero;
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
    }
}