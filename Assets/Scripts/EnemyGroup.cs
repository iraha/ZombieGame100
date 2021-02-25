using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyGroup : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) 
    {

        var player = other.GetComponent<PlayerHealth>();

        if (player != null) 
        {
            Debug.Log("当たった");
        }
        
    }

    /*
    [SerializeField] Transform _Target;  // ターゲット(Player)
    [SerializeField] float _GroupChaseRange = 10f;   // EnemyがPlayerに気づく距離

    private float _DistanceTarget = Mathf.Infinity; // _TargetとEnemyの距離
    private bool _GroupEnemyNoticed = false; // EnemyがPlayの位置に気いたらTrue
    private NavMeshAgent _NavMeshAgent;

    // Start is called before the first frame update
    void Start()
    {

        GetComponent<EnemyMovement>();
        _NavMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        GroupDistanceToTarget();
    }

    public void GroupDistanceToTarget()
    {
        // ターゲットの位置
        _DistanceTarget = Vector3.Distance(_Target.position, transform.position);

        // TargetがEngageTarget内に入ったら移動開始
        if (_GroupEnemyNoticed)
        {
            GroupEngageTarget();
        }
        else if (_DistanceTarget <= _GroupChaseRange)
        {
            _GroupEnemyNoticed = true;
            //FindObjectOfType<EnemyMovement>();
            Debug.Log("エネミーがプレイヤーに気づいた");
            FindObjectOfType<EnemyMovement>().GoToTarget();

        }

    }

    private void GroupEngageTarget()
    {
        //LookAtTarget();
        if (_DistanceTarget >= _NavMeshAgent.stoppingDistance)
        {
            _NavMeshAgent.SetDestination(_Target.position);
        }

    }

    // ギズモでChaseRangeを見えるように設定
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _GroupChaseRange);
    }
    */


}
