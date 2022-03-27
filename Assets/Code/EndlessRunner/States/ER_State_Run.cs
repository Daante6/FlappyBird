using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER_State_Run : ER_Istate
{
    private ER_StateMachine stateMachine;
    private Rigidbody2D rb;
    private BoxCollider2D boxCollider;
    private float mSpeed = 5f;
    private ER_Player player;
    public ER_State_Run(ER_Player player)
    {
        this.player = player;
    }
    public void Enter()
    {
        Debug.Log("RUN!");
        player.ChangeVelocity(mSpeed);
    }

    public void Execute()
    {
        inputHandler();
    }

    public void Exit()
    {
        
    }

    private void inputHandler()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.stateMachine.ChangeState(new ER_State_Slide(player));
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.stateMachine.ChangeState(new ER_State_Jump(player));
        }
    }
}
