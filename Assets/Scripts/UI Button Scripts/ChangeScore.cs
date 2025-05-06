using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeScore : MonoBehaviour
{
    public TextMeshProUGUI score_txt;
    // Start is called before the first frame update
    void Start()
    {
        score_txt.text = MainManager.Instance.getScore().ToString();    
    }

}
