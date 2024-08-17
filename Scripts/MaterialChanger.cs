using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    // Reference to the material
    [SerializeField]
    private Material material;

    [SerializeField]
    bool Lock = true;

    public float amplitude = 5.0f;
    [Range(-0.1f, 0.1f)]
    public float frequency = 0.05f;
    [Range(-100.0f, 100.0f)]
    public float speed = 5.0f;

    void Start()
    {
        if (material != null)
        {
            // Set initial values for the properties
            SetMaterialProperties(amplitude, frequency, speed);
        }
    }

    private void Update()
    {
        if (Lock)
        {
            SetMaterialProperties(amplitude, frequency, speed);
        }
    }

    private void SetMaterialProperties(float amplitude, float frequency, float speed)
    {
        material.SetFloat("_Amplitude", amplitude);
        material.SetFloat("_Frequency", frequency);
        material.SetFloat("_Speed", speed);
    }
}