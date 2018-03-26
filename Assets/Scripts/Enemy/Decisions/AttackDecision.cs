using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/Attack")]
public class AttackDecision : Decision {
    public override bool Decide(EnemyStateController controller)
    {
        return DoAttack(controller);
    }

    private bool DoAttack(EnemyStateController controller)
    {
        RaycastHit2D hit = Physics2D.Raycast(controller.eyes.position, controller.eyes.TransformDirection(Vector3.right), controller.enemyData.attackRange, controller.playerLayer);

        Debug.DrawRay(controller.eyes.position, controller.eyes.TransformDirection(Vector3.right) * controller.enemyData.attackRange, Color.red);

        if(hit && hit.collider.CompareTag("Player"))
        {
            // Attack the player!
            controller.chaseTarget = hit.transform; // Set our "attack target" (NOT NECESSARY)
            return true;
        }
        else
        {
            return false;
        }

        
    }
}
