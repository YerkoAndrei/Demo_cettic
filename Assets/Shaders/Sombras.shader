Shader "Sombra_simple" {
	Properties {
		_MainTex ("Textura", 2D) = "" {}
		_Outline ("Grosor Contorno", Range(0,0.01)) = 0.03
		_OutlineColor ("Color Contorno", Color) = (0, 0, 0, 0)
	}
	SubShader {
		Pass {
			Name "Contorno"
			Cull Front

			CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag
				#include "UnityCG.cginc"

				uniform float _Outline;
				uniform float4 _OutlineColor;

				struct appdata {
					float4 vertex : POSITION;
					float3 normal : NORMAL;
				};

				struct v2f {
					float4 pos : SV_POSITION;
					fixed4 color : COLOR;
				};

				fixed4 frag(v2f i) : SV_Target{
					return i.color;
				}

				v2f vert(appdata v) {
					v2f o;
					o.pos = UnityObjectToClipPos(v.vertex);
					float3 norm   = normalize(mul ((float3x3)UNITY_MATRIX_IT_MV, v.normal));
					float2 offset = TransformViewToProjection(norm.xy);
					o.pos.xy += offset * UNITY_Z_0_FAR_FROM_CLIPSPACE(o.pos.z) * _Outline;
					o.color = _OutlineColor;
					return o;
				}
			ENDCG
		}

		CGPROGRAM
		#pragma surface surf Lambert

		uniform sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutput o) {
			o.Albedo = tex2D(_MainTex, IN.uv_MainTex);
		}

		ENDCG
	} 
	FallBack "Diffuse"
}