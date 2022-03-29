using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Color color;
    private Line currLine;
    private bool dragNote = false;
    // Start is called before the first frame update
    void Start()
    {
        color = new Color((float)Random.Range(0,255)/255f, (float)Random.Range(0,255)/255f, (float)Random.Range(0,255)/255f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) dragNote = !dragNote;
        if(dragNote) {
            if(Input.GetMouseButtonDown(0)) {
                currLine = ObjectPooler.self.GetLine();
                currLine.GetComponent<LineRenderer>().startColor = Color.white;
                currLine.GetComponent<LineRenderer>().endColor = color;
            }
            if(Input.GetMouseButton(0) && currLine != null) {
                currLine.trace();
            }
            if(Input.GetMouseButtonUp(0)) {
                currLine = null;
            }
        } 
        
        else {
            if(Input.GetMouseButtonDown(0)) {
                Dot dot = ObjectPooler.self.GetDot();
                dot.GetComponent<SpriteRenderer>().color = color;
            }
        }
    }
}
