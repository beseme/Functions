Shader "Hidden/Custom/VaporWave"
{
    HLSLINCLUDE

        #include "Packages/com.unity.postprocessing/PostProcessing/Shaders/StdLib.hlsl"

        TEXTURE2D_SAMPLER2D(_MainTex, sampler_MainTex);
        TEXTURE2D_SAMPLER2D(_Offset, sampler_Offset); 
        float _OffsetScale;
        
        float4 Frag(VaryingsDefault i) : SV_Target
        {
            float2 uv = i.texcoord + float2(0, frac(_Time[2]));
            float2 offsetColor = SAMPLE_TEXTURE2D(_Offset, sampler_Offset, uv).rg * 2 - 1;
            float mag = 1;
            for(int j = 0; j < 5; j++) {
                offsetColor += mag * SAMPLE_TEXTURE2D(_Offset, sampler_Offset, offsetColor).rg * 2 - 1;
                mag *= .5;
            }
            float2 offset = offsetColor;
            float4 color = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.texcoord + offset * _OffsetScale);
            // color.rg = offset;
            // color.b = 0;
            
            return color;
        }

    ENDHLSL

    SubShader
    {
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            HLSLPROGRAM

                #pragma vertex VertDefault
                #pragma fragment Frag

            ENDHLSL
        }
    }
}
