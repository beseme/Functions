Shader "Custom/Rocks"
{
    Properties
    {
        [HDR]_Color ("Color", Color) = (1,1,1,1)
        _Amount ("Amount", Float) = 1.0
        _Speed ("Speed", Float) = 1.0
        _offsetX ("OffsetX",Float) = 0.0
        _offsetY ("OffsetY",Float) = 0.0      
        _octaves ("Octaves",Int) = 7
        _lacunarity("Lacunarity", Range( 1.0 , 5.0)) = 2
        _gain("Gain", Range( 0.0 , 1.0)) = 0.5
        _value("Value", Range( -2.0 , 2.0)) = 0.0
        _amplitude("Amplitude", Range( 0.0 , 5.0)) = 1.5
        _frequency("Frequency", Range( 0.0 , 6.0)) = 2.0
        _power("Power", Range( 0.1 , 5.0)) = 1.0
        _scale("Scale", Float) = 1.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows vertex:vert

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        float4 _Color;
        float _Amount;
        float _Speed;

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)
        
        
        
        
        float _octaves,_lacunarity,_gain,_value,_amplitude,_frequency, _offsetX, _offsetY, _power, _scale, _monochromatic, _range;
        
       
        float fbm( float2 p )
        {
            p = p * _scale + float2(_offsetX + _Time[2] * _Speed,_offsetY);
            for( int i = 0; i < _octaves; i++ )
            {
                float2 i = floor( p * _frequency );
                float2 f = frac( p * _frequency );      
                float2 t = f * f * f * ( f * ( f * 6.0 - 15.0 ) + 10.0 );
                float2 a = i + float2( 0.0, 0.0 );
                float2 b = i + float2( 1.0, 0.0 );
                float2 c = i + float2( 0.0, 1.0 );
                float2 d = i + float2( 1.0, 1.0 );
                a = -1.0 + 2.0 * frac( sin( float2( dot( a, float2( 127.1, 311.7 ) ),dot( a, float2( 269.5,183.3 ) ) ) ) * 43758.5453123 );
                b = -1.0 + 2.0 * frac( sin( float2( dot( b, float2( 127.1, 311.7 ) ),dot( b, float2( 269.5,183.3 ) ) ) ) * 43758.5453123 );
                c = -1.0 + 2.0 * frac( sin( float2( dot( c, float2( 127.1, 311.7 ) ),dot( c, float2( 269.5,183.3 ) ) ) ) * 43758.5453123 );
                d = -1.0 + 2.0 * frac( sin( float2( dot( d, float2( 127.1, 311.7 ) ),dot( d, float2( 269.5,183.3 ) ) ) ) * 43758.5453123 );
                float A = dot( a, f - float2( 0.0, 0.0 ) );
                float B = dot( b, f - float2( 1.0, 0.0 ) );
                float C = dot( c, f - float2( 0.0, 1.0 ) );
                float D = dot( d, f - float2( 1.0, 1.0 ) );
                float noise = ( lerp( lerp( A, B, t.x ), lerp( C, D, t.x ), t.y ) );              
                _value += _amplitude * noise;
                _frequency *= _lacunarity;
                _amplitude *= _gain;
            }
            _value = clamp( _value, -1.0, 1.0 );
            return pow(_value * 0.5 + 0.5,_power);
        }
        
        
        
        
        void vert (inout appdata_full v)
        {
            v.vertex.z += fbm(v.vertex.xy) * _Amount;
            // v.vertex.xyz += float3(.5,.5,.5); // += v.normal * _Amount;
        }

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            o.Emission = _Color.rgb;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
