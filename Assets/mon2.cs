using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mon2 : MonoBehaviour
{
    [SerializeField]
    private Transform targetObj;
    private float colliderOffset;
    private Animator animator;
    // Start is called before the first frame update
    // Start is called before the first frame update
   private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform mytransform = this.transform;
        var distance = Vector3.Distance(transform.position, targetObj.position);
        
        if (distance < 44)
        {
            animator.SetBool("mon2", true);
        }
      if (distance > 100)
        {
            animator.SetBool("mon3", true);
        }
        







    }


}
