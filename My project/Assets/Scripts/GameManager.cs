using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject ballPrefab;
    [SerializeField]
    private PlayerController player;
    [SerializeField]
    Camera mainCamera;
    [SerializeField]
    TextMeshProUGUI text_Score;
    
    [HideInInspector]
    public int score = 100;
    
    private float timer = 0;
    private float timerTotal = 1;
    // Start is called before the first frame update
    void Start()
    {
        // for (int i = 0; i< 300; i++)
        // {
        //     timer = 0;
        //     GameObject ball = Instantiate(ballPrefab);
        //     Vector3 v3 = new Vector3(1, 1, 1);
        //     ball.transform.position = v3;
        // }
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > timerTotal)
        {
            timer = 0;
            GameObject ball = Instantiate(ballPrefab);
            Color color = new Color(Random.Range(0,1f), Random.Range(0, 1F), Random.Range(0, 1F));
            ball.GetComponent<Renderer>().material.color = color;
            Vector3 v3 = new Vector3(Random.Range(-10f, 10f), 30, Random.Range(-10f, 10f));
            ball.transform.position = v3;
        }else{
            timer +=Time.deltaTime;
        }

        text_Score.text = "<color=#000fff>Health: </color>" + score;
    }
}
