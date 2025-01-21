using Apt.Unity.Projection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMovement : MonoBehaviour
{
    public GameObject Tracker;

    private ProjectionPlaneCamera projectionCamera;
    private Vector3 initialLocalPosition;

    void Start()
    {
        Debug.Log("init");
        projectionCamera = GetComponent<ProjectionPlaneCamera>();


        // Save the initial local position
        initialLocalPosition = projectionCamera.transform.localPosition;

        // Start the logging coroutine
        StartCoroutine(LogPositionEverySecond());
    }

    void Update()
    {
        if (Tracker == null)
            return;

        // Update the position of the projectionCamera to match this GameObject's position
        projectionCamera.transform.position = Tracker.transform.position;

    }

    IEnumerator LogPositionEverySecond()
    {
        while (true)
        {
            Debug.Log(Tracker.transform.position);
            yield return new WaitForSeconds(1);  // Wait for 1 second before logging again
        }
    }
}
