using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCredit : MonoBehaviour
{
    public GameObject credit;

    public void btnCredit(){
        if(credit.activeSelf){
            credit.SetActive(false);
        }
        else{
            credit.SetActive(true);
        }
    }
}
