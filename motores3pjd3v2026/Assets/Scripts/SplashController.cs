using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(LoadNext());
    }

    IEnumerator LoadNext()
    {
        yield return new WaitForSeconds(2f);

        GameManager.Instance.LoadScene("MenuPrincipal");
    }
}