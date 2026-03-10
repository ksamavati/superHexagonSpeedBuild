using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public static int Score { get; private set; }
    public static float ShrinkSpeed { get; private set; }

    private const float BaseShrinkSpeed = 3f;
    private const float SpeedIncreasePerScore = 0.1f;

    public TextMeshPro scoreText;
    public TextMeshPro scoreLabelText;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        Score = 0;
        ShrinkSpeed = BaseShrinkSpeed;
    }

    void Start()
    {
        if (scoreText != null)
            scoreText.gameObject.SetActive(true);
        if (scoreLabelText != null)
            scoreLabelText.gameObject.SetActive(true);

        UpdateScoreDisplay();
    }

    public void AddScore()
    {
        Score++;
        ShrinkSpeed = BaseShrinkSpeed + Score * SpeedIncreasePerScore;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        if (scoreText != null)
            scoreText.text = Score.ToString();
    }
}
