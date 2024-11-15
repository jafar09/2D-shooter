using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    void Start()
    {
        // Agar Player maydoni bo'sh bo'lsa, avtomatik topiladi
        if (player == null)
        {
            player = GameObject.Find("Player"); // O'yinchi obyektining nomi bo'yicha qidiradi
            if (player == null)
            {
                // Debug.LogError("Player obyekti topilmadi! Iltimos, Player obyektini belgilang.");
            }
        }
    }

    void LateUpdate()
    {
        if (player != null)
        {
            // Offset yordamida kamerani o'yinchi bilan bog'lash
            transform.position = player.transform.position + offset;
        }
    }
}
