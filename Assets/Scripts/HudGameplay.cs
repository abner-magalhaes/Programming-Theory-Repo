using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HudGameplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI raceStatsText;
    [SerializeField] private TextMeshProUGUI carStatsText;

    private Player player;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void Update()
    {
        raceStatsText.SetText($"LAP: {GameManager.Instance.CurrentLap}/{GameManager.Instance.TotalLaps}\nPOSITIION: {GameManager.Instance.Position}");

        if (player != null)
            carStatsText.SetText($"{player.KmVelocity()} KM/H");
    }
}
