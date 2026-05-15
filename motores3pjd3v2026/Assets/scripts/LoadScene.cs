using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void BotaoJogar()
    {
        GameManager.Instance.CarregarCena("Game");
    }

    public void BotaoSair()
    {
        Application.Quit();
    }
}