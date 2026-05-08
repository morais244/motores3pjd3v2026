using UnityEngine;

public class Bottom : MonoBehaviour
{
    public void BotaoJogar()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.LoadScene("GetStarted_Scene");
        }
    }

    public void BotaoSair()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.QuitGame();
        }
    }
}