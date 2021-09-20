using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeBall : MonoBehaviour
{
    public bool releasedFake = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && releasedFake == false)
        {
            gameObject.active = false;
            releasedFake = true;
        }

        if (releasedFake == false)
        {
            gameObject.active = true;
        }
    }
}