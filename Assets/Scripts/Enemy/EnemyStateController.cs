using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateController : MonoBehaviour {

    public EnemyData enemyData;
    public State currentState;
    public State sameState;
    public Transform eyes; // Where my character is looking
    public List<Transform> waypoints;
    public LayerMask playerLayer;

    [HideInInspector] public int nextWaypoint;
    [HideInInspector] public Transform chaseTarget; // What are we chasing?
    [HideInInspector] public EnemyAttack enemyAttack;

	// Use this for initialization
	void Start () {
        enemyAttack = GetComponent<EnemyAttack>();
	}
	
	// Update is called once per frame
	void Update () {
        currentState.UpdateState(this);
	}

    public void TransitionToState(State nextState)
    {
        if(nextState != sameState)
        {
            currentState = nextState;
        }
    }
}
