using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class neko:MonoBehaviour
{
    [SerializeField]
    private Transform targetObj;

    public GameObject target;//追跡するターゲット
    NavMeshAgent agent;//Navmeshagentを使うための変数



    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(180, 90, 90);
            agent = GetComponent<NavMeshAgent>();
        
        // InvokeRepeating("enemyAttack", 1, 1);//エネミーアタックを1秒後に1秒毎に実行
    }

    // Update is called once per frame
    void Update()
    {
        Transform mytransform = this.transform;
        var distance = Vector3.Distance(transform.position, targetObj.position);
        print(distance);
        if (distance > 30)
        {
            GetComponent<NavMeshAgent>().isStopped = true; 
        }
        if (distance < 30)
        {
            GetComponent<NavMeshAgent>().isStopped = false;

        }
            
        agent.destination = target.transform.position;//常にターゲットに向かう
    }
    private void OnTriggerEnter(Collider other)//オブジェクトに触れた時の処理
    {
        if (other.gameObject.tag == "bullet")
        {
            
        }
    }
}
