using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leantweenejemplos : MonoBehaviour
{
    [SerializeField]
    GameObject background;
    [SerializeField]
    GameObject background2;
    [SerializeField]
    GameObject texto;
    [SerializeField]
    LeanTweenType curva;

    public float time = 0.29f;

    // Start is called before the first frame update
    void Start()
    {
        background.SetActive(false);
        background2.SetActive(false);
        texto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            background.SetActive(true);
            background2.SetActive(true);
            texto.SetActive(true);
            LeanTween.moveLocalY(texto, -900f, 0f);
            LeanTween.moveLocalY(texto, 0f, time).setEase(curva);
        }
    }
}
