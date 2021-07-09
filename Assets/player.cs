using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンを切り替えるときに追加する
public class player : MonoBehaviour
{
    public GameObject Hp;
    private CharacterController characterController;
    private Vector3 Velocity;
    private float jumpPower = 8;//ジャンプ力
    private float movespeed = 10;//移動スピード
    public float sensitivityX = 15f;//マウス横の動きの強さ
    public float sensitivityY = 15f;//マウス縦の動きの強さ
    public float minimumX=-360f;//横の回転の最低値
    public float miximumX = 360f;//横の回転の最大値
    public float minimumY = -60f;//縦の回転の最低値
    public float miximumY = 60f;//縦の回転の最大値
    float rotationX = 0f;//縦軸の回転量
    float rotationY = 0f;//縦軸の回転量
    public GameObject verRot;//縦移動させるオブジェクト
    public GameObject horRot;//横移動させるオブジェクト

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, miximumY);
        verRot.transform.localEulerAngles = new Vector3(-rotationY, -90, 0);
       horRot.transform.localEulerAngles = new Vector3(0, rotationX, 0);
        if(Input.GetKey(KeyCode.A))
        {
            characterController.Move(this.gameObject.transform.forward * -1f * movespeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            characterController.Move(this.gameObject.transform.forward  * movespeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.W))
        {
            characterController.Move(this.gameObject.transform.right *-1f* movespeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            characterController.Move(this.gameObject.transform.right * movespeed * Time.deltaTime);
        }

       

        characterController.Move(Velocity * Time.deltaTime);
        Velocity.y += Physics.gravity.y * Time.deltaTime;
        if(characterController.isGrounded)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                Velocity.y = jumpPower;
            }
        }


    }
    
    }


