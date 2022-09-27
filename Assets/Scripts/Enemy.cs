using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Bullet")
        {
            ScoreManager.instance.ChangeScore(3);
            Destroy(gameObject);
        }
        if (other.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeHealth(10);
            Destroy(gameObject);
        }
    }
}
