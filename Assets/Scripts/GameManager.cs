using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int money = 0;
    public int Money
    {
        get { return money; }
        set
        {
            money = Mathf.Max(0, value);

            if (OnMoneyChanged != null)
                OnMoneyChanged.Invoke(money);
        }
    }

    public event System.Action<int> OnMoneyChanged;
    private void Awake()
    {
        FindObjectOfType<Ship>().OnShipDestroyed += () => OnGameEnded();
    }
    void Start()
    {
        Money = 0;
    }
    void OnGameEnded()
    {
        var points = FindObjectOfType<AsteroidWaveController>().CurrentWaveNumber * 10;
        GameState.SetCurrentResult(points);

        SceneManager.LoadScene("gameover");
    }
}
