using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    private GameManager manager;

    private void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        livesText.text = $"Balls: {manager.lives.ToString()}";
    }
}
