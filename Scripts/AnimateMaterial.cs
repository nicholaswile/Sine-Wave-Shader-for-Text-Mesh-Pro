using UnityEngine;
using System.Collections;

public class AnimateMaterial : MonoBehaviour
{
    public float start_amp = 100.0f;
    public float end_amp = 5.0f;
    [Range(1, 1000)]
    public int num_frames = 120;

    private float elapsed_frames = 0.0f;

    public bool bounce = false;

    [SerializeField]
    private MaterialChanger mat;

    private void Update()
    {
        if (elapsed_frames < num_frames)
        {
            float t = elapsed_frames / num_frames;
            float this_amp = lerp(start_amp, end_amp, t);
            elapsed_frames++;

            if (mat != null)
            {
                mat.amplitude = this_amp;
            }
        }
        else if (bounce)
        {
            elapsed_frames = 0.0f;
            float temp_amp = start_amp;
            start_amp = end_amp;
            end_amp = temp_amp;
        }
    }

    private float lerp(float a, float b,  float t)
    {
        return a + (b - a) * t;
    }
}