namespace NikoNiko
{
    using UnityEditor;
    public class CustomSDFShaderGUI : ShaderGUI
    {
        public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] properties)
        {
            // Draw the default properties
            base.OnGUI(materialEditor, properties);

            // Find custom properties
            MaterialProperty amplitude = FindProperty("_Amplitude", properties);
            MaterialProperty frequency = FindProperty("_Frequency", properties);

            // Draw custom properties
            materialEditor.ShaderProperty(amplitude, "Amplitude");
            materialEditor.ShaderProperty(frequency, "Frequency");
        }
    }
}