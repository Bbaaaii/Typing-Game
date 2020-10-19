using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class WordBank : MonoBehaviour
{
    private List<string> orgWords = new List<string>()
    {
        "carrot", "potato", "unicorn", "bug", "rocket", "doggo", "woof","beautiful","poggers","ka-chow",
    };

    private List<string> workingWords = new List<string>();

    // Start is called before the first frame update
    private void Awake()
    {
        workingWords.AddRange(orgWords);
        ConvertToLower(workingWords);
        ConvertToLower(workingWords);
    }


    private void Shuffle(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temp = list[i];

            list[i] = list[random];
            list[random] = temp;
        }

    }

    private void ConvertToLower(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
            list[i] = list[i].ToLower();
    }

    public string GetWord()
    {
        string NewWord = string.Empty;
        if (workingWords.Count != 0)
        {
            NewWord = workingWords.Last();
            workingWords.Remove(NewWord);
        }
        return NewWord;
    }
}