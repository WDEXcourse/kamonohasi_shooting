using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koa : MonoBehaviour
    
{
    public GameObject bullet;//発射する弾
    private float bulletSpeed = 1000;//弾のスピード
    private Vector3 force;//弾を飛ばす力の変数
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullets = Instantiate(bullet) as GameObject;
            bullets.transform.position = this.transform.position;
            force = this.gameObject.transform.forward * bulletSpeed;
            bullets.GetComponent<Rigidbody>().AddForce(force);
            Destroy(bullets.gameObject, 4);
        }
    }
}
