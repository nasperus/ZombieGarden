using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] float speed;
    float damage = 50f;



    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponent<Health>();
        health.DealDamage(damage);
        Destroy(gameObject);


    }
}
