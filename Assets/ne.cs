using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ne : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyBullet;
    private float bulletSpeed = 1000;//敵の弾のスピード
    Vector3 force;//弾にかける力
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("enemyAttack", 1, 1);//エネミーアタックを1秒後に1秒毎に実行
    }

    // Update is called once per frame
    void Update()
    {

    }
    void enemyAttack()
    {
       // GameObject enemyBullets = Instantiate(enemyBullet) as GameObject;
        //enemyBullets.transform.position = this.transform.position;
       // force = this.gameObject.transform.forward * bulletSpeed;
       // enemyBullets.GetComponent<Rigidbody>().AddForce(force);
       // Destroy(enemyBullets.gameObject, 4);
    }
}
