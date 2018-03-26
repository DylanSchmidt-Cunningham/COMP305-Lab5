using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Patrol")]
public class PatrolAction : Action {
    public override void Act(EnemyStateController controller)
    {
        Patrol(controller);
    }

    private void Patrol(EnemyStateController controller)
    {
        // HOW DOES OUR ENEMY PATROL?!?!
        Vector2 walkVector = Vector2.MoveTowards(
            controller.transform.position,
            controller.waypoints[controller.nextWaypoint].position,
            Time.fixedDeltaTime * controller.enemyData.patrolSpeed);

        controller.transform.position = new Vector3(walkVector.x, controller.transform.position.y, controller.transform.position.z);

        float distanceToWaypoint = Mathf.Abs(controller.transform.position.x - controller.waypoints[controller.nextWaypoint].position.x);

        if(distanceToWaypoint < 0.2)
        {
            controller.nextWaypoint = (controller.nextWaypoint + 1) % controller.waypoints.Count;
        }
    }
}
