using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/Look")]
public class LookDecision : Decision {
    public override bool Decide(EnemyStateController controller)
    {
        return Look(controller);
    }

    private bool Look(EnemyStateController controller)
    {
        // Determine if we are looking at anything
        RaycastHit2D hit = Physics2D.Raycast(controller.eyes.position, controller.eyes.TransformDirection(Vector3.right), controller.enemyData.chaseRange, controller.playerLayer);

        Debug.DrawRay(controller.eyes.position, controller.eyes.TransformDirection(Vector3.right) * controller.enemyData.chaseRange, Color.green);
        
        
        // Deteremine if what we are look at is the player
        if(hit && hit.collider.CompareTag("Player"))
        {
            // Set my player as a chase target
            controller.chaseTarget = hit.transform;
            return true;
        }
        else
        {
            return false;
        }
    }
}
