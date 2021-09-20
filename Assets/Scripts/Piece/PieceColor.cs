using UnityEngine;

public class PieceColor : MonoBehaviour
{

    private void ChooseColor()
    {
        //TODO
        // set spriteRenderer.sprite to a random sprite that is present above. DONE IN ANOTHER METHOD!
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
       Destroy(gameObject);
    }

}