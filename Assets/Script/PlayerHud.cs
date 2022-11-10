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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateHp()
    {
        HealthSlider.value = _player.PlayerHealth;
    }

}
