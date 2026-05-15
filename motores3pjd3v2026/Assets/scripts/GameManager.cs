using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public enum GameState
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

    [SerializeField] private GameState estadoAtual;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        MudarEstado(GameState.Iniciando);
    }

    private void Start()
    {
        CarregarCena("Splash");
    }

    public void MudarEstado(GameState novoEstado)
    {
        estadoAtual = novoEstado;
        Debug.Log($"<color=green>Estado do Jogo:</color> <b>{estadoAtual}</b>");
    }

    public void CarregarCena(string nomeDaCena)
    {
        SceneManager.LoadScene(nomeDaCena);

        switch (nomeDaCena)
        {
            case "Menu":
                MudarEstado(GameState.MenuPrincipal);
                break;
            case "Game":
                MudarEstado(GameState.Gameplay);
                break;
            case "_Boot":
                MudarEstado(GameState.Iniciando);
                break;
        }
    }

    public void AlocarInputAoPlayer(PlayerInput playerInput)
    {
        if (playerInput != null)
        {
            Debug.Log("GameManager: Input alocado com sucesso ao Player.");
        }
    }
}