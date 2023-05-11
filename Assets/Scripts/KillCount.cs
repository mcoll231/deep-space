using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KillCount : MonoBehaviour
{
    public static KillCount singleton;

    static int NumberKills = 0;
    // Start is called before the first frame update
    void Start()
    {
        singleton = this;
    }

    public void incrementkills ()
    {
        NumberKills=NumberKills+1;
        GetComponent<TMP_Text>().text=("score; "+ NumberKills);
        //add canvas functionalit
    }
}
