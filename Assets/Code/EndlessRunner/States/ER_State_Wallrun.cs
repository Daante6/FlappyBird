using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER_State_Wallrun : ER_Istate
{
    private float mSpeed = 4.5f;
    private float wallrunUp = 2f;
    private float wallrunGravity = 0.05f;
    private ER_Player player;
    public ER_State_Wallrun(ER_Player player)
    {
        this.player = player;
    }
    public void Enter()
    {
        player.ChangeVelocity(mSpeed);
        player.appearance.ChangeImage(StateEnum.Wallrun);

        player.ResetVelocityY();
        player.AddVelocity(new Vector2(0,wallrunUp));
    }

    public void Execute()
    {
        inputHandler();
        player.AddVelocity(new Vector2(0, wallrunGravity));
    }

    public void Exit()
    {

    }

    private void inputHandler()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.stateMachine.ChangeState(new ER_State_Jump(player));
        }
    }
}
