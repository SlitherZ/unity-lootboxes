using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text getText, prizesText;
    public List<string> prizeList = new List<string>();
    public List<string> prizes = new List<string>();
    public string filepath  = "/Assets/Prizes/prizestext.txt";

    public KeyCode pullCode;

    void Start(){
        ReadTextFile();
    }

    void Update()
    {
        if(Input.GetKeyDown(pullCode)){
            string[] prizeListArray = prizeList.ToArray();
            int prizeGet = Random.Range(0, prizeListArray.Length);
            string textedPrize = prizeListArray[prizeGet];
            prizes.Add(textedPrize);
            getText.text = $"You get : {textedPrize}";
            prizesText.text += $"\n {textedPrize}";
        
        }
    }

    void ReadTextFile() {
        string[] lines = File.ReadAllLines(filepath);
        foreach (string line in lines) {
            string[] textReader = line.Split(":");

            int repeat = int.Parse(textReader[0].Trim());
            string prizeOpt = textReader[1].Trim();

            for(int i = 0; i < repeat;i++){
                prizeList.Add(prizeOpt);
            }
        
        } 
}
}
