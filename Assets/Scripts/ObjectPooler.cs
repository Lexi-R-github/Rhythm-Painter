using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler self;
    public Dot dotPrefab;
    public int dotAmount = 100;
    private List<Dot> dots;
    public Line linePrefab;
    public int lineAmount = 50;
    private List<Line> lines;

    void Awake()
    {
        self = this;
        dots = new List<Dot>(dotAmount);
        for(int i=0; i<dotAmount; i++)
        {
            Dot dot = Instantiate(dotPrefab);
            dot.transform.SetParent(transform);
            dot.gameObject.SetActive(false);
            dots.Add(dot);
        }

        lines = new List<Line>(lineAmount);
        for(int i=0; i<dotAmount; i++)
        {
            Line line = Instantiate(linePrefab);
            line.transform.SetParent(transform);
            line.gameObject.SetActive(false);
            lines.Add(line);
        }
    }

    public Dot GetDot()
    {
        foreach(Dot d in dots)
        {
            if (!d.gameObject.activeInHierarchy)
            {
                d.gameObject.SetActive(true);
                return d;
            }
        }

        Dot dot = Instantiate(dotPrefab);
        dot.transform.SetParent(transform);
        dot.gameObject.SetActive(true);
        return dot;
    }

    public Line GetLine()
    {
        foreach(Line l in lines)
        {
            if (!l.gameObject.activeInHierarchy)
            {
                l.gameObject.SetActive(true);
                return l;
            }
        }

        Line line = Instantiate(linePrefab);
        line.transform.SetParent(transform);
        line.gameObject.SetActive(true);
        return line;
    }
}
