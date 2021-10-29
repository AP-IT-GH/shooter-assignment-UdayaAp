using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    public float force = 10f;
    public float tiltForce = 100f;
    public float score = 0f;
    public Text scoreText;



    public void OnParticleCollision(GameObject collider)
    {
        
    }
    private void onParticle(Collider collider)
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float translationVertical = Input.GetAxis("Vertical") * force;
        float transationHorizontal = Input.GetAxis("Horizontal") * force;
        float rotation = Input.GetAxis("Horizontal") * tiltForce;
        float rotation2 = Input.GetAxis("Vertical") * tiltForce;



        // Make it move 10 meters per second instead of 10 meters per frame...
        translationVertical *= Time.deltaTime;
        transationHorizontal *= Time.deltaTime;
        rotation *= Time.deltaTime;
        //rotation2 *= Time.deltaTime;

        // Move translation along the object's z-axis
        //transform.Translate(0, 0, translation);
        transform.position = new Vector3(transform.localPosition.x - transationHorizontal, transform.localPosition.y,transform.localPosition.z - translationVertical);

        if(!Mathf.Approximately(rotation,0f) && !Mathf.Approximately(rotation2, 0f))
        {
            // Rotate around our y-axis
            //transform.Rotate(-0, 0, rotation);
            //rb.freezeRotation = true;
            //rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0, rotation, 0)));
        }

        rb.AddRelativeForce(new Vector3(transform.localPosition.x - transationHorizontal, transform.localPosition.y, transform.localPosition.z - translationVertical));
        

    }
}
