using Unity.Burst.CompilerServices;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    [SerializeField] private ColorManager _cm;
    private MeshRenderer _mr;

    private void Awake()
    {
        _cm = FindAnyObjectByType<ColorManager>();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            MeshRenderer _meshRenderer = this.GetComponentInParent<MeshRenderer>();
            _meshRenderer.material.color = _cm.currentColor;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            MeshRenderer _meshRenderer = this.GetComponentInParent<MeshRenderer>();
            _meshRenderer.material.SetColor("_BaseColor", Color.gray);
        }
    }
}
