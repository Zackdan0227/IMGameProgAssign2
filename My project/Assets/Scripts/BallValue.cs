using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallValue : MonoBehaviour
{
    [SerializeField]
    int heal;
    // Start is called before the first frame update
    void Start()
    {
        heal = Random.Range(10, 300);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
