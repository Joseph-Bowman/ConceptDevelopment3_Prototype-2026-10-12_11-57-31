using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("Player Stats")]
    [SerializeField] private int health = 3;
    [SerializeField] private int speed = 10;
    [SerializeField] private int damage = 3;
    [SerializeField] private int attackRate = 5;

    private InputSystem_Actions playerInput;

    private void OnEnable()
    {
        playerInput = new InputSystem_Actions();
        playerInput.Enable();
        playerInput.Player.Enable();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
