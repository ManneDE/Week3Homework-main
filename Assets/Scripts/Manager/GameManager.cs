using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private Transform pieces = null;

    [SerializeField]
    private GameObject piecePrefab = null;

    [SerializeField]
    private GameObject ballPrefab = null;

    [SerializeField]
    private EdgeCollider2D border;

    public bool releasedManager = false;

    //TODO
    //Using const data defined above "Instantiate" new pieces to fill the view. DONE IN OTHER METHOD!

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && releasedManager == false)
        {
            Instantiate(ballPrefab);
            releasedManager = true;
        }
    }
}