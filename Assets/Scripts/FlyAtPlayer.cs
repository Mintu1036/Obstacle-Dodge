using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 10f; 
    [SerializeField] Transform player;
    Vector3 playerPosition;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveTopPlayer();
        DestroyWhenReached();
    }

    void MoveTopPlayer()
    {
        transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}