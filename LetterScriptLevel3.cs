using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterScriptLevel3 : MonoBehaviour
{
    public LetterScript G;
    public Ascript A;
    public Mscript M;
    public Escript E;

    private void FixedUpdate()
    {

        if (M.MCollected == false)
        {

            if (E.ECollected == true || G.GCollected == true || A.ACollected == true)
            {

                FindObjectOfType<LevelManager>().EndGame();

            }
        }

        else if (M.MCollected == true)
        {

            if (E.ECollected == false)
            {

                if (G.GCollected == true || A.ACollected == true)
                {

                    FindObjectOfType<LevelManager>().EndGame();

                }

            }

            else if (E.ECollected == true)
            {

                if (G.GCollected == false)
                {
                    if (A.ACollected == true)
                    {
                        FindObjectOfType<LevelManager>().EndGame();
                    }


                }

                else if (G.GCollected == true)
                {
                    if (A.ACollected == true)
                    {
                        SceneManager.LoadScene(0);
                    }
                }
            }
        }
    }
}

