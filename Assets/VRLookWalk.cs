using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour {

    [SerializeField]
    Transform vrCamera;

    [SerializeField]
    float speed = 30f;

    CharacterController character;
	// Use this for initialization
	void Start ()
    {
        character = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (vrCamera.eulerAngles.x >= -10f && vrCamera.eulerAngles.x < 10f)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            character.SimpleMove(forward * speed * Time.deltaTime);
        }
	}
}
