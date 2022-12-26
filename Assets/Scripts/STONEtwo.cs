using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STONEtwo : MonoBehaviour
{
    public GameObject stone;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("stoneshot", 0, 3f);
    }

   
    void stoneshot()
    {
        Instantiate(stone, new Vector3(Random.Range(-2, 2), 6, 0), Quaternion.identity);
    }
}
