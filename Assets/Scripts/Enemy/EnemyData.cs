using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/EnemyStats")]
public class EnemyData : ScriptableObject {
    public float moveSpeed = 1f;
    public float lookRange = 10f; // How far can my zombie look?

    public float patrolSpeed = 0.5f; // How fast my zombie moves when in the Patrol state

    public float chaseRange = 5.0f; // How far until my zombie starts to chase the target
    public float chaseSpeed = 1.5f; // How fast my zombie moves when in the Chase state

    public float attackRange = 0.1f; // How close do I have to be to my target before I start attacking
    public float attackRate = 1.0f; // How fast do I attack?
    public float attackDamage = 5.0f; // How much damage does my attack do?
}
