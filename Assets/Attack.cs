using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
	private LineRenderer lineRederer;
    // Start is called before the first frame update
    void Start()
    {
	lineRederer = GetComponent<LineRenderer>();

	lineRederer.enabled = true;

	lineRederer.useWorldSpace = true;

    }

    // Update is called once per frame
    void Update()
    {
        lineRederer.SetPosition(0,transform.position);

            lineRederer.SetPosition(1, Input.mousePosition);

    }
}
