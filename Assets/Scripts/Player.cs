using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        color = new Color((float)Random.Range(0,255)/255f, (float)Random.Range(0,255)/255f, (float)Random.Range(0,255)/255f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Dot dot = ObjectPooler.self.GetDot();
            dot.GetComponent<SpriteRenderer>().color = color;
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dot.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
    }
}
