using UnityEngine;

public class GridPosition : MonoBehaviour
{

    [SerializeField]
    Vector2 m_Position;
    void OnMouseDown()
    {
        Debug.Log("Cllick");
    }
}
