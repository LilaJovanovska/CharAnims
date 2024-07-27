using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementChar : MonoBehaviour
{
    [SerializeField] private GameObject player;
    //private Rigidbody rb;

    [SerializeField] private float speed;

    [SerializeField] private GameObject ground;

    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        SimpleDodge();
        DodgeSideways();
        Jump();
        Run();
        IdleForTooLong();
    }

    private void Run()
    {
        var isRunning = Input.GetKey(KeyCode.LeftShift);
        var isRunningHash = Animator.StringToHash("isRunning");
        _animator.SetBool(isRunningHash, isRunning);
        var isRunningInjured = Input.GetKey(KeyCode.LeftControl);
        var isRunningInjuredHash = Animator.StringToHash("isHpLow");
        _animator.SetBool(isRunningInjuredHash, isRunningInjured);
    }

    private void Move()
    {
        var isWalking = Input.GetKey(KeyCode.A)
                        || Input.GetKey(KeyCode.D)
                        || Input.GetKey(KeyCode.W)
                        || Input.GetKey(KeyCode.S);
        var isWalkingHash = Animator.StringToHash("isWalking");
        _animator.SetBool(isWalkingHash, isWalking);
    }

    private void SimpleDodge()
    {
        var isDodging = Input.GetKey(KeyCode.Space);
        var isDodgingHash = Animator.StringToHash("isDodging");
        _animator.SetBool(isDodgingHash, isDodging);
    }

    private void DodgeSideways()
    {
        //code for dodging left
        var isDodgingLeft = Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.Space);
        var isDodgingLeftHash = Animator.StringToHash("isDodgingLeft");
        _animator.SetBool(isDodgingLeftHash, isDodgingLeft);

        //code for dodging right
        var isDodgingRight = Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.Space);
        var isDodgingRightHash = Animator.StringToHash("isDodgingRight");
        _animator.SetBool(isDodgingRightHash, isDodgingRight);

    }

    private void Jump()
    {
        var isJumping = Input.GetKey(KeyCode.F);
        var isJumpingHash = Animator.StringToHash("isJumping");
        _animator.SetBool(isJumpingHash, isJumping);

        //fix code: mora F da drzham celo vreme dur skokne za da se izvrshi cela animacija
    }

    private void IdleForTooLong()
    {

    }
}