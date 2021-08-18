using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class nehp : MonoBehaviour
{
    private Slider setSlider;//スライダーを使用する時の変数
    public GameObject slider;//使用するHPゲージ
    private float neHpber = 10f;//体力
    // Start is called before the first frame update
    void Start()
    {
        setSlider = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        setSlider.value = neHpber;//slider.valueを体力にする
        if (setSlider.value <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    private void OnTriggerEnter(Collider other)//何かに触れた時の処理
    {
        if (other.gameObject.tag == "bullet")//もし触れた物のタグがballetだったら
        {
            neHpber--;//Hpberを１づつへらす
        }

    }
}
