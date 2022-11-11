using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        this.Speed =4.0f ;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) GoLeft();
        if (Input.GetKey(KeyCode.RightArrow)) GoRight();
        if (Input.GetKey(KeyCode.UpArrow)) GoUp();
        if (Input.GetKey(KeyCode.DownArrow)) GoDown();

    }


    void GoLeft()
    {
        Vector3 position = this.transform.position;
        position.x-= this.Speed*Time.deltaTime;
        this.transform.position = position;
    }
    void GoRight()
    {
        Vector3 position = this.transform.position;
        position.x+= this.Speed * Time.deltaTime;
        this.transform.position = position;
    }
    void GoUp()
    {
        Vector3 position = this.transform.position;
        position.y += this.Speed * Time.deltaTime;
        this.transform.position = position;
    }
    void GoDown()
    {
        Vector3 position = this.transform.position;
        position.y -= this.Speed * Time.deltaTime;
        this.transform.position = position;
    }
}
