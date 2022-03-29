using UnityEngine;

public class GameStart : MonoBehaviour
{
    private PlayerController playerController;

    public float playerSpeed;
    public float playerSpeedDown;

    [SerializeField] private GameObject[] HideObject;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            playerController.speed = playerSpeed;
            playerController.speedDown = playerSpeedDown;

            foreach (var hide in HideObject)
            {
                hide.SetActive(false);
            }
        }
    }
}
