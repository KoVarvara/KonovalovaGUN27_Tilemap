using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private Tilemap _map;

    private Camera _camera;

    private void Start()
    {
        _map = GetComponent<Tilemap>();
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickWorldPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int clickCellPosition = _map.WorldToCell(clickWorldPosition);

            _player.transform.position = clickCellPosition;
        }
    }

}
