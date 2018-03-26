using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/State")]
public class State : ScriptableObject {
    public Action[] actions;
    public Transition[] transitions;

    public void UpdateState(EnemyStateController controller)
    {
        // Evaluate our actions and decisions/transitions
        DoActions(controller);
        CheckTransitions(controller);
    }

    private void DoActions(EnemyStateController controller)
    {
        // Loop through all actions associated with this state.
        for (int i = 0; i < actions.Length; i++)
        {
            // Do actions.
            actions[i].Act(controller);
        }
    }

    private void CheckTransitions(EnemyStateController controller)
    {
        for (int i = 0; i < transitions.Length; i++)
        {
            bool decisionSucceeded = transitions[i].decision.Decide(controller);

            if(decisionSucceeded)
            {
                controller.TransitionToState(transitions[i].trueState);
            }
            else
            {
                controller.TransitionToState(transitions[i].falseState);
            }
        }
    }
}
