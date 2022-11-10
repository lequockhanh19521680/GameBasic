using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) GoLeft();
        if (Input.GetKeyDown(KeyCode.RightArrow)) GoRight();
        if (Input.GetKeyDown(KeyCode.UpArrow)) GoUp();
        if (Input.GetKeyDown(KeyCode.DownArrow)) GoDown();

    }

    void GoLeft()
    {
        Vector3 position = this.transform.position;
        position.x--;
        this.transform.position = position;
    }
    void GoRight()
    {
        Vector3 position = this.transform.position;
        position.x++;
        this.transform.position = position;
    }
    void GoUp()
    {
        Vector3 position = this.transform.position;
        position.y++;
        this.transform.position = position;
    }
    void GoDown()
    {
        Vector3 position = this.transform.position;
        position.y--;
        this.transform.position = position;
    }
}
