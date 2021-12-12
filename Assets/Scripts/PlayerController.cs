using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private int maxItemCount = 4;
    [SerializeField] private UIController uiController;
    private int _itemCount;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    private void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        _rigidbody.AddForce(x * speed, 0, z * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            other.gameObject.SetActive(false);
            _itemCount++;
            if (IsGameClear(_itemCount))
            {
                uiController.SetViewGameClear(true);
            }

            uiController.SetGetItemCount(_itemCount);
        }
    }

    private bool IsGameClear(int getItemCount)
    {
        return getItemCount >= maxItemCount;
    }
}