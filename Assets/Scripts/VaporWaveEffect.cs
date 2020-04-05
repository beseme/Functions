using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(VaporWaveEffect), PostProcessEvent.AfterStack, "Custom/VaporWave")]
public class VaporWave : PostProcessEffectSettings {
    public FloatParameter offsetScale = new FloatParameter {value = 1f};
    public TextureParameter offset = new TextureParameter();
}

public sealed class VaporWaveEffect : PostProcessEffectRenderer<VaporWave> {
    private static readonly int OffsetScale = Shader.PropertyToID("_OffsetScale");
    private static readonly int Offset = Shader.PropertyToID("_Offset");

    public override void Render(PostProcessRenderContext context) {
        var sheet = context.propertySheets.Get(Shader.Find("Hidden/Custom/VaporWave"));
        // sheet.properties.SetFloat("_Blend", settings.blend);
        sheet.properties.SetFloat(OffsetScale, settings.offsetScale.value);
        if (settings.offset.value != null) {
            sheet.properties.SetTexture(Offset, settings.offset.value);
        }
        context.command.BlitFullscreenTriangle(context.source, context.destination, sheet, 0);
    }
}