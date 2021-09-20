using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    public GameObject Ball;
    private Ball baller;

    public GameObject FakeBall;
    private FakeBall baller2;

    public GameObject GameManager;
    private GameManager baller3;

    private void Start()
    {
        baller = Ball.GetComponent<Ball>();
        baller2 = FakeBall.GetComponent<FakeBall>();
        baller3 = GameManager.GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        collision.GetComponent<Ball>().Respawn();
        baller.released = false;
        baller2.releasedFake = false;
        baller3.releasedManager = false;
    }
}