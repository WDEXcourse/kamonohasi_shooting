using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m2 : MonoBehaviour
{
    [SerializeField]
    private Transform targetObj;
    private float colliderOffset;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
   

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
