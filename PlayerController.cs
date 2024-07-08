using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Movement
    public float horizontalInput;
    public float verticalInput;
    public float speed = 5;
    public float startingY = -4.52f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(4.28f, startingY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if ((transform.position.x < 0.92f))
        {
            transform.position = new Vector3(0.92f, startingY, 0);
        }

        if ((transform.position.x > 7.61f))
        {
            transform.position = new Vector3(7.61f, startingY, 0);
        }
    }
}
