using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    [SerializeField] private GameObject player, restartPanel;
    [SerializeField] private Vector2 playerScale;
    public float scaleMinus;
    public float scalePlus;
    public float maxScale;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        transform.localScale = playerScale;

        if (playerScale.x <= 0.01f)
        {
            playerScale.x = 0.0f;
            restartPanel.SetActive(true);
            Time.timeScale = 0;
        }

        if (playerScale.x >= maxScale)
        {
            playerScale.x = maxScale;
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            playerScale.x += scaleMinus;
        }

        if (other.CompareTag("Item_Scale"))
        {
            playerScale.x += scalePlus;
            Destroy(other.gameObject);
        }

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

}
