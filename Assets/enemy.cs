using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemy : MonoBehaviour
{

    
    public GameObject target;//追跡するターゲット
    NavMeshAgent agent;//Navmeshagentを使うための変数
    
   
   
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //InvokeRepeating("enemyAttack", 1, 1);//エネミーアタックを1秒後に1秒毎に実行
    }

    // Update is called once per frame
    void Update()

    {
        
       
        agent.destination = target.transform.position;//常にターゲットに向かう
    }
    private void OnTriggerEnter(Collider other)//オブジェクトに触れた時の処理
    {
        if (other.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
        }
    }

        
    
   

}
