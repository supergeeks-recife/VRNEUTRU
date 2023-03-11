using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Counter : MonoBehaviour
{
    public int contador;
    public TMP_Text textHUD;

    void Start()
    {
        contador = 0;
    }

    public void IncrementContador()
    {
        contador++;
        //contador += 1;
        //contador = contador + 1
        Debug.Log("Contados: " + contador);
        textHUD.text = contador.ToString();
    }
}
