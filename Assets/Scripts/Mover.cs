using UnityEngine;

public class Mover : MonoBehaviour

{
    [SerializeField] private float moveSpeed = 10f;
    void Start()
    {
        PrintInsruction();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInsruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or wasd");
        Debug.Log("Don't bump into objects!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0; 
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    } 

}