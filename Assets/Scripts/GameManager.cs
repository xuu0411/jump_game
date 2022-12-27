using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 使用 LoadScene 必要的引用程式敘述 !!
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject hpGauge;
    int Life = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Life <= 0)
            // 遊戲重新開始
            SceneManager.LoadScene("GameScene");
    }
    
     public void DecreaseHp()
     {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        Life -= 1;
    }
     public void Restart()
     {
         SceneManager.LoadScene("GameScene");
     }
}
