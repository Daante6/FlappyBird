using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER_State_Run : ER_Istate
{
    private float mSpeed = 5f;
    private ER_Player player;
    public ER_State_Run(ER_Player player)
    {
        this.player = player;
    }
    public void Enter()
    {
        player.ChangeVelocity(mSpeed);

        player.appearance.ChangeImage(StateEnum.Run);
    }

    public void Execute()
    {
        InputHandler();
    }

    public void Exit()
    {
        
    }

    private void InputHandler()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.stateMachine.ChangeState(new ER_State_Slide(player));
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.stateMachine.ChangeState(new ER_State_Jump(player));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.stateMachine.ChangeState(new ER_State_TigerJump(player));
        }
    }
}
