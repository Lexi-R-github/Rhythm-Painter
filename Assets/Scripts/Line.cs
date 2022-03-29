using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private int index = 0;
    // Start is called before the first frame update
    void Start() {
    }
    void OnEnable()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void trace() {
        if(index > lineRenderer.positionCount-1) lineRenderer.positionCount++;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lineRenderer.SetPosition(index, new Vector3(mousePos.x, mousePos.y, 0));
        index++;
    }
}
