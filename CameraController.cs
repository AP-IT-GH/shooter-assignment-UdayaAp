using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Vector3 offset;
    [SerializeField] float smoothingSpeed = 10f;
    Transform playerTransform;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition = playerTransform.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothingSpeed);
        transform.LookAt(playerTransform);
    }
}
