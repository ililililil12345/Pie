using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Number : MonoBehaviour
{
    [SerializeField] private Pie p;
    public TMP_Text txt;

    //[SerializeField] private int mySeq;
    public int myNum;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = "_";
    }

    // Update is called once per frame
    void Update()
    {
        //if (p.seq == mySeq)
        //{
        //    txt.text = $"{myNum}";
        //}
    }
}
