using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private int countHourglasses=0;
    [SerializeField] private ParticleSystem particle;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag=="Collectable")
        {
            HourglassesUp();
            QuestManager.Instance.HourGlassesText = countHourglasses.ToString();
            Destroy(hit.gameObject);
        }
    }

    private void HourglassesUp()
    {
        if (countHourglasses>=4)
        {
            particle.Play();
            QuestManager.Instance.TaskText = "Yaşlı Amcanın Yanına Koş";
        }
        else
        {
            countHourglasses++;
        }
    }
}
