using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    GameObject STONE1;
    // Start is called before the first frame update
    void Start()
    {
        STONE1 = GameObject.Find("GameManager");
        Destroy(gameObject, 3); // 3秒後，刪除自己
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // 當箭頭碰到其他有碰撞體的東西時
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            Destroy(gameObject); // 碰到有碰撞體的東西就刪除自己
               STONE1.GetComponent<GameManager>().DecreaseHp();
        }
    }

    
}
