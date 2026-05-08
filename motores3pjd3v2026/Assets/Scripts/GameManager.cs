using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System.Collections;

public enum GameState
{
    Iniciando,
    MenuPrincipal,
    Gameplay
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private GameState _currentState;
    public GameState CurrentState => _currentState;

    public PlayerInput playerInput;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        LoadScene("Splash");
    }

    public void ChangeState(GameState newState)
    {
        _currentState = newState;
        Debug.Log($"<color=cyan>[GameManager]</color> Estado: <b>{_currentState}</b>");
    }

    public void LoadScene(string sceneName)
    {
        if (CanLoadScene(sceneName))
        {
            SceneManager.LoadScene(sceneName);
            UpdateStateFromScene(sceneName);
        }
    }

    private bool CanLoadScene(string sceneName)
    {
        return true;
    }

    private void UpdateStateFromScene(string sceneName)
    {
        switch (sceneName)
        {
            case "Splash":
                ChangeState(GameState.Iniciando);
                break;
            case "MenuPrincipal":
                ChangeState(GameState.MenuPrincipal);
                break;
            case "GetStarted_Scene":
                ChangeState(GameState.Gameplay);
                break;
        }
    }

    public void AssignPlayerInput(PlayerInput input)
    {
        playerInput = input;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}