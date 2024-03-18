using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance { get => instance; }

    private int level = 0;
    public int Level { get => level; }
    
    [SerializeField] private Text scoreText;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SetScore(int score)
    {
        this.scoreText.text = score.ToString();
    }

    public void ContinueGame()
    {
        this.level++;
        GameManager.Instance.ClearMap();
        GameManager.Instance.CustomMap();
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
