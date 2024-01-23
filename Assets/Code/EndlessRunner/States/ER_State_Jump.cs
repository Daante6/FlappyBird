using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER_State_Jump : ER_Istate
{
    private float mSpeed = 5.5f;
    ER_Player player;
    float jumpSpeed = 7.5f;
    float cooldown = 0.2f;

    public ER_State_Jump(ER_Player player)
    {
        this.player = player;
    }
    public void Enter()
    {
        player.ChangeVelocity(mSpeed);

        Vector2 jumpingForce = new Vector2(0, jumpSpeed);
        player.ResetVelocityY();
        player.AddForces(jumpingForce);

        player.appearance.ChangeImage(StateEnum.Jump);
    }

    public void Execute()
    {
        if (player.isGrounded && cooldown <= 0f)
        {
            player.stateMachine.ChangeState(new ER_State_Run(player));
        }else
        {
            cooldown -= Time.deltaTime;
        }
    }

    public void Exit()
    {
        
    }
}
