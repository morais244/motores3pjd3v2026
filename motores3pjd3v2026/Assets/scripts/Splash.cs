using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(TimerSplash());
    }

    IEnumerator TimerSplash()
    {
        yield return new WaitForSeconds(2.0f);
        GameManager.Instance.CarregarCena("Menu");
    }
}