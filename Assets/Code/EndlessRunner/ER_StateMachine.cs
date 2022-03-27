using UnityEngine;

public class ER_StateMachine
{
    public ER_Istate currentlyRunningState;
    private ER_Istate previousState;
    public void ChangeState(ER_Istate newState)
    {
        if(this.currentlyRunningState != null)
        {
            this.currentlyRunningState.Exit();
        }
        this.previousState = this.currentlyRunningState;
        this.currentlyRunningState = newState;
        this.currentlyRunningState.Enter();
    }
    public void ExecuteStateUpdate()
    {
        var runningState = this.currentlyRunningState;
        if(runningState != null)
        {
            runningState.Execute();
        }
    }
    public void SwitchToPreviousState()
    {
        this.currentlyRunningState.Exit();
        this.currentlyRunningState = this.previousState;
        this.currentlyRunningState.Enter();
    }
}
