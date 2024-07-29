using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAnims : StateMachineBehaviour
{
    [SerializeField] private float _timerUntilIdle;
    [SerializeField] private int _numberOfAnims;

    private bool _isIdle;
    private float _idleTime;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        ResetIdle(animator);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (_isIdle == false)
        {
            _idleTime += Time.deltaTime;
        }

        if (_idleTime > _timerUntilIdle)
        {
            _isIdle = true;
            int idleTooMuch = Random.Range(1, _numberOfAnims + 1);

            animator.SetFloat("idleTooMuch", idleTooMuch);
        }
        else if (stateInfo.normalizedTime % 1 > 0.98)
        {
            ResetIdle(animator);
        }

    }

    private void ResetIdle(Animator animator)
    {
        _isIdle = false;
        _idleTime = 0;

        animator.SetFloat("idleTooMuch", 0);
    }

}
