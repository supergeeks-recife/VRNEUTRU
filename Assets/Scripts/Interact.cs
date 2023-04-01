using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{ 
    private MeshRenderer malha;
    private Color corOriginal;

    public Image circleProgress;
    public float totalTime = 3;
    private bool grvStatus;
    private float grvTimer;
    
    void Start()
    {
        malha = GetComponent<MeshRenderer>();
        corOriginal = malha.material.color;
    }

    void Update()
    {
        if(grvStatus == true)
        {
            grvTimer += Time.deltaTime;
            circleProgress.fillAmount = grvTimer / totalTime;
        }
        else
        {
            grvTimer = 0;
            circleProgress.fillAmount = 0;
        }
    }

    public void Selected()
    {
        malha.material.color = Color.blue;
        grvStatus = true;
    }

    public void NotSelected()
    {
        malha.material.color = corOriginal;
        grvStatus = false;
    }
}
