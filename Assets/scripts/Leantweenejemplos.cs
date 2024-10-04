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
    [SerializeField]
    GameObject cubo;

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
            if (texto.activeSelf)
            {
            HidePopup();
            }
        else
            {
                ShowPopUp();
            }
           
        }
    }
    public void ShowPopUp()
    {
        background.SetActive(true);
        LeanTween.moveLocalY(background, 900f, 0f);
        LeanTween.moveLocalY(background, 0f, time).setEase(curva);
        background2.SetActive(true);
        LeanTween.moveLocalX(background2, -9000f, 0f);
        LeanTween.moveLocalX(background2, 0f, time).setEase(curva);
        texto.SetActive(true);
        LeanTween.moveLocalY(texto, -900f, 0f);
        LeanTween.moveLocalY(texto, 0f, time).setEase(curva);
        LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 1f, time).setEase(curva);
        LeanTween.alphaCanvas(background2.GetComponent<CanvasGroup>(), 1f, time).setEase(curva);
        LeanTween.alphaCanvas(texto.GetComponent<CanvasGroup>(), 1f, time).setEase(curva);
        LeanTween.moveLocalY(cubo, 1f, time).setEase(curva).setOnComplete(() => {
            LeanTween.moveLocalZ(cubo, -4f, time).setEase(curva);
        });
    }
    public void HidePopup()
    {
        LeanTween.moveLocalY(background, 900, time).setEase(curva);
        LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 0f, time).setEase(curva);
        LeanTween.moveLocalX(background2, -9000, time).setEase(curva);
        LeanTween.alphaCanvas(background2.GetComponent<CanvasGroup>(), 0f, time).setEase(curva);
        LeanTween.alphaCanvas(texto.GetComponent<CanvasGroup>(), 0f, time).setEase(curva);
        LeanTween.moveLocalY(cubo, -20f, time).setEase(curva);
        LeanTween.moveLocalZ(cubo, 20f, time).setEase(curva);
        LeanTween.moveLocalY(texto, -900, time).setEase(curva).setOnComplete(()=> {
            background.SetActive(false);
            background2.SetActive(false);
            texto.SetActive(false);
        });
    }

}
