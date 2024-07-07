using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChar : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody rb;

    [SerializeField] private float speed;

    [SerializeField] private GameObject ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftAndRight();
        SimpleDodge();
        DodgeSideways();
        Jump();
    }

    private void MoveLeftAndRight()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            
        }
    }

    private void SimpleDodge()
    {

    }

    private void DodgeSideways()
    {

    }

    private void Jump()
    {

    }
}
