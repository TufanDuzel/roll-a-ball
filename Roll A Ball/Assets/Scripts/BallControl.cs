using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public int speed;
    public Rigidbody physics;
    public int point;
    public int cubes;
    public Text pointText;
    public Text gameOverText;

    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vector = new Vector3(horizontal, 0, vertical);
        physics.AddForce(vector * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
        other.gameObject.SetActive(false);

        point += 1;
        pointText.text = "Point: " + point;

        if (point == cubes)
        {
            gameOverText.gameObject.SetActive(true);
        }
    }
}
