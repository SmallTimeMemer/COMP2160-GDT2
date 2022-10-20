using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw(InputAxes.Horizontal);
        float vertical = Input.GetAxisRaw(InputAxes.Vertical);

        Vector3 direciton = new Vector3(horizontal, 0f, vertical).normalized;

        if(direciton.magnitude > 0.1f)
        {
            transform.position += direciton * moveSpeed * Time.deltaTime;
        }

    }
}