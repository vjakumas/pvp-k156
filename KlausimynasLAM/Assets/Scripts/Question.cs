using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question
{
    public string themeName { get; set; }
    public string question { get; set; }
    public string highlightedText { get; set; }
    public string opt1 { get; set; }
    public string opt2 { get; set; }
    public string opt3 { get; set; }
    public int correctOpt { get; set; }
    public string bonusInfo { get; set; }
    public string picName { get; set; }
    public Question(string t, string q, string qh, string o1, string o2, string o3, int c, string bonus, string pic)
    {
        themeName = t;
        question = q;
        highlightedText = qh;
        opt1 = o1;
        opt2 = o2;
        opt3 = o3;
        correctOpt = c;
        bonusInfo = bonus;
        picName = pic;
    }
    public string ReturnCorrectOptText()
    {
        if (correctOpt == 1)
        {
            return opt1;
        }

        if (correctOpt == 2)
        {
            return opt2;
        }

        if (correctOpt == 3)
        {
            return opt3;
        }
        return "";
    }
}
