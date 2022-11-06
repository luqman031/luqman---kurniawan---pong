using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreControl : MonoBehaviour
{
    public Text skorkanan;
    public Text skorkiri;

    public ScoreManager manager;


    private void Update()
    {
        skorkanan.text = manager.rightScore.ToString();
        skorkiri.text = manager.leftScore.ToString();
    }
}
