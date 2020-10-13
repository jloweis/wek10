using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int moveSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MovementH = Input.GetAxis("Horizontal");
        float MovementV = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(1,0,0) * moveSpeed * Time.deltaTime * MovementH);
        transform.Translate(new Vector3(0,1,0) * moveSpeed * Time.deltaTime * MovementV);
    }
}
