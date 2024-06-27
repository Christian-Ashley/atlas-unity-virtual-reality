using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scenechanger : MonoBehaviour
{
    public Button Bowling;
    // Start is called before the first frame update
    void Start()
    {
        Bowling.onClick.AddListener(delegate {LevelSelect(1);});
    }

    public void LevelSelect(int lvl)
    {
        SceneManager.LoadScene("Bowling");
    }
}
