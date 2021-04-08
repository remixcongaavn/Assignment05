using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"motivation", "artist", "inch", "sunshine", "velvet", "bald",
                            "cluster", "sunrise", "characteristic", "hypothesize", "publisher", "rotation",
                            "award", "contradiction", "knee", "palm", "carpet", "urge", "allow", "makeup",
                            "want", "pier", "straighten", "pigeon", "superior", "entertainment", "happen",
                            "cabinet", "secure", "side", "cook", "gift", "to", "gravity", "insurance", "museum",
                            "fibre", "wild", "giant", "honor", "tense", "onion", "timetable", "diplomat",
                            "cultivate", "orange", "apple", "teenager", "neighborhood" };

    public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
