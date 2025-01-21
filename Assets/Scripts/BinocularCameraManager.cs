using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BinocularCameraManager : MonoBehaviour
{

    public GameObject rightCamera;
    public GameObject leftCamera;

    public GameObject targetRepresentation;

    public Vector3 target_position_real = new Vector3(0, 0, 0);

    private Vector3 unit_vector;
    private Vector3 target_position_game = new Vector3(0, 0, 0);
    private Vector3 camera_center;


    // Start is called before the first frame update
    void Start()
    {
        calculateUnit();
    }

    void calculateUnit()
    {
        unit_vector = (rightCamera.transform.localPosition - leftCamera.transform.localPosition) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // calc unit length
        calculateUnit(); 

        // multiply game coord scale
        target_position_game = target_position_real * unit_vector.magnitude;

        // get center of camera
        camera_center = (rightCamera.transform.localPosition + leftCamera.transform.localPosition) / 2;

        // calculate targets game world coord 
        target_position_game = camera_center + target_position_game;

        targetRepresentation.transform.localPosition = target_position_game;
    }
}
