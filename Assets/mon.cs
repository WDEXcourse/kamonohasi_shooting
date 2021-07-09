using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mon : MonoBehaviour
{
    [SerializeField]
    private Transform targetObj;
    private float colliderOffset;
    private Animator animator;
    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        //collider = GetComponent<CharacterController>().radius + targetObj.GetComponent<CharacterController>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        Transform mytransform = this.transform;
        var distance = Vector3.Distance(transform.position, targetObj.position) ;
        print(distance);
        if (distance < 40)
        {
            Debug.Log("a");
            animator.SetBool("mon1",true);
        }
        if (distance > 100)
        {
            animator.SetBool("mon3",true);
        }
            
         
       
        
    }
}
