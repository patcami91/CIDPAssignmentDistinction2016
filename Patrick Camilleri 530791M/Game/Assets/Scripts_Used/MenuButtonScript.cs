using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtonScript : MonoBehaviour
{


    public void menutostartgame()
    {
        SceneManager.LoadScene("SceneLvl1");
    }

    public void Instructionstomenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void menuToinstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
	public void creditanimtomenu()
	{
		SceneManager.LoadScene("Menu");
	}
    public void menutocredit()
    {
        SceneManager.LoadScene("Credits");
    }
    public void menutoquitgame()
    {
        Application.Quit(); 
    }

    public void RestartLvl1()
    {
        SceneManager.LoadScene("SceneLvl1");
    }
    public void RestartLvl2()
    {
        SceneManager.LoadScene("SceneLvl2");
    }
    public void RestartLvl3()
    {
        SceneManager.LoadScene("SceneLvl3");
    }
    public void ExitToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}