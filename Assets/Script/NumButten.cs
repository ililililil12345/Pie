using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumButten : MonoBehaviour
{
    [SerializeField] private Pie p;
    [SerializeField] private Camera cam;

    [SerializeField] private int buttenNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NumberButten()
    {
        if (p.numbers[p.seq].myNum == buttenNumber)
        {
            p.numbers[p.seq].txt.text = $"{buttenNumber}";
            cam.transform.Translate(new Vector2(1.6f, cam.transform.position.y));
        }
        
    }
}
