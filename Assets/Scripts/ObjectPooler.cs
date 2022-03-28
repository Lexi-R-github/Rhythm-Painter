using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler self;
    public Dot dotPrefab;
    public int dotAmount = 100;
    private List<Dot> dots;

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
}
