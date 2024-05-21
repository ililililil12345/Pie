using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject startButten;
    [SerializeField] private GameObject buttens;
    [SerializeField] private Camera cam;

    public enum GameState
    {
        loby,
        game
    }
    public GameState gameState;

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.loby;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState == GameState.game)
        {
            startButten.SetActive(false);
            buttens.SetActive(true);
        }
        if (gameState == GameState.loby)
        {
            buttens.SetActive(false);
        }
    }

    public void StartButten()
    {
        gameState = GameState.game;
        cam.transform.Translate(new Vector2(1.6f, cam.transform.position.y));
    }
}
