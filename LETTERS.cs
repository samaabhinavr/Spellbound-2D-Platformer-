using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LETTERS : MonoBehaviour
{
    public LetterScript G;
    public Ascript A;
    public Mscript M;
    public Escript E;
    public GameObject portal; 

    private void FixedUpdate()
    {

        if (G.GCollected == false)
        {

            if (A.ACollected == true || M.MCollected == true || E.ECollected == true)
            {

                FindObjectOfType<LevelManager>().EndGame();

            }
        }

        else if (G.GCollected == true)
        {

            if (A.ACollected == false)
            {

                if (M.MCollected == true || E.ECollected == true)
                {

                    FindObjectOfType<LevelManager>().EndGame();

                }

            }

            else if (A.ACollected == true)
            {

                if (M.MCollected == false)
                {
                    if (E.ECollected == true)
                    {
                        FindObjectOfType<LevelManager>().EndGame();
                    }

                 
                }

                else if(M.MCollected == true)
                {
                    if (E.ECollected == true)
                    {
                        SceneManager.LoadScene(3);
                    }
                }
            }   
        }
    }
}
    
