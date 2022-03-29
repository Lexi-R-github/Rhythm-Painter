using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public class Point {
        float x;
        float y;
        public Point(float x, float y) {
            this.x = x;
            this.y = y;
        }
    }
    List<Point> points = new List<Point>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void trace(float x, float y) {
        points.Add(new Point(x,y));
    }
}
