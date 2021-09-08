using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Transform targetObj;
    private float colliderOffset;
    private Animator animator;
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

        if (distance < 40)
        {
            Debug.Log("i");
            animator.SetBool("monn1", true);
        }
        if (distance > 100)
        {
            animator.SetBool("monn3", true);
        }




    }
}

