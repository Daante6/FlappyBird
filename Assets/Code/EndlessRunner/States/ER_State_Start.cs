using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER_State_Start : ER_Istate
{
    private float mSpeed = 0;
    private ER_Player player;
    
    public ER_State_Start(ER_Player player)
    {
        this.player = player;
    }
    public void Enter()
    {
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.stateMachine.ChangeState(new ER_State_Run(player));
        }
    }
}
