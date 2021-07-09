using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI操作をする時に追記
using UnityEngine.SceneManagement;//シーンを変更する時に追記
public class HP : MonoBehaviour
{
    private Slider setSlider;//スライダーを使用する時の変数
    public GameObject slider;//使用するHPゲージ
    private float Hpber= 10f;//体力
    // Start is called before the first frame update
    void Start()
    {
        setSlider = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        setSlider.value = Hpber;//slider.valueを体力にする
        if (setSlider.value<=0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    private void OnTriggerEnter(Collider other)//何かに触れた時の処理
    {
        if(other.gameObject.tag == "enemybullet")//もし触れた物のタグがenemyballetだったら
        {
            Hpber--;//Hpberを１づつへらす
        }
        
    }
}
