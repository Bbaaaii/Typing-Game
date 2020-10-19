using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public WordBank wordBank = null;
    public Crystal crystal = null;
    public Text wordOutput = null;
    public Text wordsCompleted = null;
    

    private string remainingWord = string.Empty;
    private string currentWord = string.Empty;
    private int counter = -1;
    
    private void Start()
    {
        SetCurrentWord();
        
    }

    private void SetCurrentWord()
    {
        currentWord = wordBank.GetWord();
        counter += 1;
        SetRemainingWord(currentWord);
    }
    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
        wordsCompleted.text = "Score:" + counter; 
    }
        
    private void Update()
    {
        CheckInput();

    }

    private void CheckInput()
    {
        if(Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;

            if (keysPressed.Length == 1)
                EnterLetter(keysPressed);
        }
    }

    private void EnterLetter(string typedLetter)
    {
        if(IsCorrectLetter(typedLetter))
        {
            RemoveLetter();

            if (IsWordComplete())
                SetCurrentWord();
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;

    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }

    private bool IsWordComplete()
    {
        return
            remainingWord.Length == 0;
        


    }

}
