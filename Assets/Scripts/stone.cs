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
        Destroy(gameObject, 3); // 3���A�R���ۤv
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // ��b�Y�I���L���I���骺�F���
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            Destroy(gameObject); // �I�즳�I���骺�F��N�R���ۤv
               STONE1.GetComponent<GameManager>().DecreaseHp();
        }
    }

    
}
