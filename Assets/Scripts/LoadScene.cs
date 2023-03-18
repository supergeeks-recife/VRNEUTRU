using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    public void VaiProFim()
    {
        SceneManager.LoadScene("CenaMaluca");
    }

    public void VaiProComeco()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
