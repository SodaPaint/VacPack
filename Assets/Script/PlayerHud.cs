using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHud : MonoBehaviour
{

    [SerializeField] Slider HealthSlider;

    movement _player;
    private void Awake()
    {
        _player = FindObjectOfType<movement>();
        HealthSlider.value = _player.PlayerHealth;
    }


   

    public void UpdateHp()
    {
        HealthSlider.value = _player.PlayerHealth;
    }

}
