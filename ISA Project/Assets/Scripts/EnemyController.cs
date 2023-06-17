using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    private Renderer enemyRenderer;
    private bool isFading = false;
    private float fadeSpeed = 2f;
    private bool gameOver = false;
    private float fadeDuration = 10f; // Duration of the fade out effect in seconds

    private void Start()
    {
        enemyRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (!gameOver && isFading)
        {
            if (Input.GetKey(KeyCode.E))
            {
                FadeOut();
            }
            else
            {
                GameOver();
            }
        }
        else if (!isFading && Input.GetKeyDown(KeyCode.E) && !gameOver)
        {
            isFading = true;
            StartCoroutine(FadeOutAndLoadNextScene());
        }
    }

    private void FadeOut()
    {
        float fadeAmount = fadeSpeed * Time.deltaTime;
        float newAlpha = enemyRenderer.material.color.a - fadeAmount;
        enemyRenderer.material.color = new Color(enemyRenderer.material.color.r, enemyRenderer.material.color.g, enemyRenderer.material.color.b, newAlpha);

        if (enemyRenderer.material.color.a <= 0)
        {
            LoadNextScene();
        }
    }

    private IEnumerator FadeOutAndLoadNextScene()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            FadeOut();
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        LoadNextScene();
    }

    private void LoadNextScene()
    {
 
        SceneManager.LoadScene("Manual2");
    }

    private void GameOver()
    {
        SceneManager.LoadScene("GameOver3");
    }
}
