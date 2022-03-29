using UnityEngine;
using UnityEngine.UI;

public class PlayerItems : MonoBehaviour
{
    private ItemsCount itemCount;

    public Text items;

    public GameObject effect;

    private void Start()
    {
        itemCount = FindObjectOfType<ItemsCount>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item_Star"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            itemCount.count ++;
            items.GetComponent<Text>().text = itemCount.count.ToString();
            Destroy(other.gameObject);
        }
    }
}
