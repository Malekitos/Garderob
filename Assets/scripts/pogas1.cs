using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pogas1 : MonoBehaviour {


    public string vards;
    public int vecums;
    public string teksts;

        public GameObject ievadesVards;
        public GameObject ievadesVecums;
        public GameObject tekstsParadisana;

        public void uzglabaTekstu()
        {

            vards = ievadesVards.GetComponent<InputField>().text;
            vecums = int.Parse(ievadesVecums.GetComponent<InputField>().text);

            teksts = "Sikais-" + vards + ", vinam: " + vecums + " gadi";

        tekstsParadisana.GetComponent<Text>().text = teksts;
        }

    }
