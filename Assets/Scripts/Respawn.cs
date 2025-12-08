using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameRespawn : MonoBehaviour
{
    public Player pl;
    public Transform respawnPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        pl.score = pl.score + 1;
        other.gameObject.transform.position = respawnPoint.position;
    }
}

// if (other.gameObject.CompareTag("Player") || Input.GetKeyDown("r"))
