using UnityEngine;

public class SetColor : MonoBehaviour
{
    [SerializeField] private ColorManager _cm;
    private MeshRenderer _mr;

    private void Awake()
    {
        _mr = GetComponentInParent<MeshRenderer>();
        _cm = FindAnyObjectByType<ColorManager>();
    }

    private void OnMouseDown()
    {
        _mr.material.color = _cm.currentColor;
    }

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            _mr.material.SetColor("_BaseColor", Color.gray);
        }
    }
}
