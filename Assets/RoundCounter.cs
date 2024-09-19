using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int      roundNum = 1;
    private Text    uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();   
    }

    // Update is called once per frame
    public void ChangeRound() {
        roundNum += 1;
        uiText.text = "Round " +  roundNum.ToString();
    }
}
