using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(EdgeCollider2D))]
public class Tail : MonoBehaviour
{   
    float pointSpace = 0.1f;
    public Transform snake;

    List<Vector2> points;

    LineRenderer line;
    EdgeCollider2D edgeCol;

    void Start()
    {   
        line = GetComponent<LineRenderer>();
        edgeCol = GetComponent<EdgeCollider2D>();

        points = new List<Vector2>();
        
        SetPoint();
    }

    void Update()
    {
        if (Vector2.Distance(points.Last(), snake.position) > pointSpace)
        {
            SetPoint();
        }

    }

    public void SetPoint()
    {
        if (points.Count > 1)
        {
            edgeCol.points = points.ToArray<Vector2>();
        }
    
        points.Add(snake.position);

        line.positionCount = points.Count;
        line.SetPosition(points.Count-1 , snake.position);

    }
}
