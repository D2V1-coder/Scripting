using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    public AudioSource audioSource;
    public AudioClip collectSound;

    private int health = 10;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void CollectCoins()
    {
        coins++;

        audioSource.PlayOneShot(collectSound);

        print("Collected coins:" + coins);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Players health"+ health);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
