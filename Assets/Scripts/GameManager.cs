using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text getText, prizesText;
    public string[] prizeList;
    public List<string> prizes = new List<string>();

    public KeyCode pullCode;

    void Update()
    {
        if(Input.GetKeyDown(pullCode)){
            int prizeGet = Random.Range(0, prizeList.Length);
            string textedPrize = prizeList[prizeGet];
            prizes.Add(textedPrize);
            getText.text = $"You get : {textedPrize}";
            prizesText.text += $"\n {textedPrize}";
        
        }
    }
}
