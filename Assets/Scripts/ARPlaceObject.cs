using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARSubsystems;
using System;

public class ARPlaceObject : MonoBehaviour
{
    public GameObject indicator;
    public ARSessionOrigin ARSessionOrigin;
    private Pose Pose;
    private bool valid = false;

    // Start is called before the first frame update
    void Start()
    {
        ARSessionOrigin = GetComponent<ARSessionOrigin>();
    }

    // Update is called once per frame
    void Update()
    {
        PlacementPose();
        UpdatePlacementIndicator();
    }

    private void UpdatePlacementIndicator()
    {
        if (valid)
        {
            indicator.SetActive(true);
            indicator.transform.SetPositionAndRotation(Pose.position, Pose.rotation);
        }
        else
        {
            indicator.SetActive(false);
        }
    }

    private void PlacementPose()
    {
        Vector3 screencenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        var rayCastMgr = GetComponent<ARRaycastManager>();
        rayCastMgr.Raycast(screencenter, hits, TrackableType.Planes);

        valid = hits.Count > 0;
        if (valid)
        {
            Pose = hits[0].pose;
        }
    }
}
