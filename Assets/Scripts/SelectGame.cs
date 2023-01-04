using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameType
{
    staging,
    production
}

public class SelectGame : MonoBehaviour
{
    
    public void OpenGame(string g)
    {
        string url = "";
        if (Controller.instance.gameType == GameType.staging)
        {
            switch (g)
            {
                case "chicken":
                    url="http://staging-play.cryptofightclub.io/chicken-run";
                    break;
                case "bear":
                    url = "http://staging-play.cryptofightclub.io/fight-the-bear";
                    break;
                case "warrior":
                    url = "http://staging-play.cryptofightclub.io/warrior";
                    break;
                case "tutorial":
                    url = "http://staging-play.cryptofightclub.io/tutorial";
                    break;
            }   
        }
        else if (Controller.instance.gameType == GameType.production)
        {
            switch (g)
            {
                case "chicken":
                    url = "http://play.cryptofightclub.io/chicken-run";
                    break;
                case "bear":
                    url = "http://play.cryptofightclub.io/fight-the-bear";
                    break;
                case "warrior":
                    url = "http://play.cryptofightclub.io/warrior";
                    break;
                case "tutorial":
                    url = "http://play.cryptofightclub.io/tutorial";
                    break;
            }
        }
        Application.ExternalEval("window.open('" + url + "','_self')");
        Application.Quit();
    }
}
