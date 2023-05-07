using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atteluParadisana : MonoBehaviour {

	public GameObject beensImg;
    public GameObject lacisImg;
    public GameObject masinaImg;
    public GameObject tanteImg;
    public GameObject kreisais;
    public GameObject labais;
    public GameObject mainigaAttels;
    public Sprite[] atteluMasivs;
    public GameObject izmSlaiders;
    public GameObject rotSlaiders;


    public void binaAttelosana(bool vertiba)
    {
        beensImg.SetActive(vertiba);
        kreisais.GetComponent<Toggle>().interactable = vertiba;
        labais.GetComponent<Toggle>().interactable = vertiba;
    }
    public void lasisAttelosana(bool vertiba)
    {
        lacisImg.SetActive(vertiba);
    }
    public void masinaAttelsana(bool vertiba)
    {
        masinaImg.SetActive(vertiba);
    }
    public void tanteAttelosana(bool vertiba)
    {
        tanteImg.SetActive(vertiba);
    }

    public void paLabi(bool vertiba)
    {
        beensImg.transform.localScale = new Vector2(-1, 1);
    }

    public void paKreisi(bool vertiba)
    {
        beensImg.transform.localScale = new Vector2(1, 1);
    }


    public void izkritosais(int skaitlis)
    {
        switch (skaitlis) {
         case 0:
                mainigaAttels.GetComponent<Image>().sprite = atteluMasivs[0];break;
        
         case 1:
                mainigaAttels.GetComponent<Image>().sprite = atteluMasivs[1]; break;
    
         case 2:
                mainigaAttels.GetComponent<Image>().sprite = atteluMasivs[2];break;
        }

}

    public void mainitLielumu() {
        float pasreizejaVartiba = izmSlaiders.GetComponent<Slider>().value;
        mainigaAttels.transform.localScale = new Vector2(1f * pasreizejaVartiba, 1f * pasreizejaVartiba);
    }

    public void mainitRotaciju()
    {
        float pasreizejaVartiba = rotSlaiders.GetComponent<Slider>().value;
        mainigaAttels.transform.localRotation = Quaternion.Euler(0,0,pasreizejaVartiba*360);
    }
}
