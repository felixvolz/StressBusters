using UnityEngine;
using System.Collections;

public class fvUIManagerScript : MonoBehaviour
{

    public GameObject canvas;

    public void HideCanvas()
    {
        canvas.SetActive(false);
    }
}
