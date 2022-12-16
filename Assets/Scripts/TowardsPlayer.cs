using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowardsPlayer : MonoBehaviour
{
    private GameObject player;
    [SerializeField] float speed = 0.5f;

    private void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed*Time.deltaTime);
        if (Vector3.Distance(transform.position,player.transform.position) < 0.1)
        {
            player.GetComponent<PlayerLife>().DecreaseLifeBar();
            Destroy(gameObject);
        }
        transform.LookAt(player.transform);
    }
}
