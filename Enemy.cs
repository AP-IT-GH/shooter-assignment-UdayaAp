using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosion;
    private void OnParticleCollision(GameObject other)
    {
        FindObjectOfType<Score>().AddScore();
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
