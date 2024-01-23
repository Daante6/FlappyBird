using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER_State_Slide : ER_Istate
{
    ER_Player player;
    float mSpeed = 4.5f;
    float lifeSpan = 1.2f;
    public ER_State_Slide(ER_Player player)
    {
        this.player = player;
    }
    public void Enter()
    {
        player.capsuleCollider.offset = new Vector2(player.capsuleCollider.offset.x, -0.25f);
        player.capsuleCollider.size = new Vector2(0.5f, 0.5f);

        player.ChangeVelocity(mSpeed);
        player.appearance.ChangeImage(StateEnum.Slide);
    }

    public void Execute()
    {
        lifeSpan -= Time.deltaTime;
        if (lifeSpan <= 0)
        {
            player.stateMachine.ChangeState(new ER_State_Run(player));
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.stateMachine.ChangeState(new ER_State_Jump(player));
        }
    }

    public void Exit()
    {
        player.capsuleCollider.offset = new Vector2(player.capsuleCollider.offset.x, 0);
        player.capsuleCollider.size = new Vector2(1, 1);
    }
}
