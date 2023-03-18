using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{ 
    private MeshRenderer malha;
    private Color corOriginal;

    void Start()
    {
        malha = GetComponent<MeshRenderer>();
        corOriginal = malha.material.color;
    }

    public void Selected()
    {
        malha.material.color = Color.blue;
    }

    public void NotSelected()
    {
        malha.material.color = corOriginal;
    }
}
