using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] Transform _TargetObject;  // ターゲット
    [SerializeField] float _TurnSpeed = 5f;

    public float _DistanceTarget = Mathf.Infinity; // _TargetObjectとEnemyの距離
    bool _Noticed = false;

    NavMeshAgent _NavMeshAgent;


    void Start()
    {

        _NavMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void LateUpdate()
    {

        //DistanceTarget();
        //_DistanceTarget = Vector3.Distance(_TargetObject.position, transform.position);

        _NavMeshAgent.SetDestination(_TargetObject.position);
    }

    public void GoToTarget() 
    {

        if (_Noticed == true) 
        {
            
        }

    }

    private void LookAtTarget()
    {
        Vector3 Direction = (_TargetObject.position - transform.position).normalized;
        Quaternion _LookRotation = Quaternion.LookRotation(new Vector3(Direction.x, 0, Direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, _LookRotation, Time.deltaTime * _TurnSpeed);
    }


}
