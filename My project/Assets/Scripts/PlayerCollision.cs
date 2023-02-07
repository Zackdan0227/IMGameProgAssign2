using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("ball"))
		{
            print("Eat");
			Destroy(collision.gameObject);
            gameManager.score+=(int) Random.Range(10, 100);
		}
	}
}
