
using UnityEngine;

public class ControllPlayer : MonoBehaviour
{
    private CharacterController characterController;
    [SerializeField] private float _speed = 5f;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }


    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        characterController.Move(move * Time.deltaTime * _speed);
    }


}
