using UnityEngine;

public class SetColor : MonoBehaviour
{
    [SerializeField] private ColorManager _cm;
    [SerializeField] private MeshRenderer _mr;
    [SerializeField] private Color _defaultColor;

    private void Awake()
    {
        if (_cm == null) _cm = FindAnyObjectByType<ColorManager>();
        if (_mr == null) _mr = GetComponentInParent<MeshRenderer>();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            _mr.material.color = _cm.currentColor;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(1))
        {
            _mr.material.SetColor("_BaseColor", Color.gray);
        }
    }

    private void Update()
    {
        // Non resetto qui perchè altrimenti resetta tutti i cubi con lo stesso colore inziale
        //if (Input.GetMouseButton(1))
        //{
        //    _mr = this.GetComponentInParent<MeshRenderer>();
        //    _mr.material.SetColor("_BaseColor", Color.gray);
        //}
    }
}
