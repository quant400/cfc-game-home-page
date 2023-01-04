using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public static Controller instance;
    [SerializeField]
    GameObject GameSelect;
    public GameType gameType;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
            instance = this;
    }
    public void OpenGameSelect()
    {
        GameSelect.SetActive(true);
    }
    
}
