using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LETTERSLVL2 : MonoBehaviour
{
    public LetterScript G;
    public Ascript A;
    public Mscript M;
    public Escript E;
    public GameObject portal;

    private void FixedUpdate()
    {

        if (M.MCollected == false)
        {

            if (A.ACollected == true || G.GCollected == true || E.ECollected == true)
            {

                FindObjectOfType<LevelManager>().EndGame();

            }
        }

        else if (M.MCollected == true)
        {

            if (A.ACollected == false)
            {

                if (G.GCollected == true || E.ECollected == true)
                {

                    FindObjectOfType<LevelManager>().EndGame();

                }

            }

            else if (A.ACollected == true)
            {

                if (G.GCollected == false)
                {
                    if (E.ECollected == true)
                    {
                        FindObjectOfType<LevelManager>().EndGame();
                    }


                }

                else if (G.GCollected == true)
                {
                    if (E.ECollected == true)
                    {
                        SceneManager.LoadScene(4);
                    }
                }
            }
        }
    }
}

