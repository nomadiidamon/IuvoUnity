using System;
using UnityEngine;

namespace IuvoUnity
{
    namespace _ExtensionMethods
    {
        public static class MaterialExtensions
        {
            // ===== Common Shader Properties =====

            public static void WithMainColor(this Material material, Color color)
            {
                if (material.HasProperty("_Color"))
                    material.SetColor("_Color", color);
                else
                    Debug.LogWarning($"Material '{material.name}' does not have a _Color property.");
            }

            public static void WithMainTexture(this Material material, Texture texture)
            {
                if (material.HasProperty("_MainTex"))
                    material.SetTexture("_MainTex", texture);
                else
                    Debug.LogWarning($"Material '{material.name}' does not have a _MainTex property.");
            }

            public static void WithMainTextureOffset(this Material material, Vector2 offset)
            {
                if (material.HasProperty("_MainTex"))
                    material.SetTextureOffset("_MainTex", offset);
            }

            public static void WithMainTextureScale(this Material material, Vector2 scale)
            {
                if (material.HasProperty("_MainTex"))
                    material.SetTextureScale("_MainTex", scale);
            }

            public static void WithMainTextureTiling(this Material material, Vector2 tiling)
            {
                material.WithMainTextureScale(tiling);
            }

            public static void WithMetallic(this Material material, float metallic)
            {
                if (material.HasProperty("_Metallic"))
                    material.SetFloat("_Metallic", Mathf.Clamp01(metallic));
            }

            public static void WithEmissionColor(this Material material, Color color)
            {
                if (material.HasProperty("_EmissionColor"))
                    material.SetColor("_EmissionColor", color);
            }

            // ===== Shader Handling =====

            public static void WithShader(this Material material, Shader shader)
            {
                if (shader != null)
                {
                    material.shader = shader;
                }
                else
                {
                    Debug.LogWarning($"Null shader passed to material '{material.name}'. Shader not changed.");
                }
            }

            public static void WithShader(this Material material, string shaderName)
            {
                Shader shader = Shader.Find(shaderName);
                if (shader != null)
                {
                    material.shader = shader;
                }
                else
                {
                    Debug.LogWarning($"Shader '{shaderName}' not found. Material '{material.name}' was not updated.");
                }
            }

            public static void WithShader(this Material material, string shaderName, string fallbackShaderName)
            {
                Shader shader = Shader.Find(shaderName);
                if (shader == null)
                {
                    Debug.LogWarning($"Shader '{shaderName}' not found. Falling back to '{fallbackShaderName}'.");
                    shader = Shader.Find(fallbackShaderName);
                }

                if (shader != null)
                {
                    material.shader = shader;
                }
                else
                {
                    Debug.LogError($"Both shader '{shaderName}' and fallback '{fallbackShaderName}' not found. Material '{material.name}' shader not changed.");
                }
            }

            // ===== Transparency Mode (use with caution) =====
            public static void WithRenderingMode(this Material material, int mode)
            {
                if (material.HasProperty("_Mode"))
                {
                    material.SetInt("_Mode", mode);
                }
                else
                {
                    Debug.LogWarning($"Material '{material.name}' does not support '_Mode'. Use a compatible shader for transparency.");
                }
            }

            // ===== Utility =====

            public static bool HasProperty(this Material material, string propertyName)
            {
                return material.HasProperty(propertyName);
            }

            // ===== Advanced =====

            public static void WithBuffer(this Material material, string propertyName, ComputeBuffer buffer)
            {
                if (material.HasProperty(propertyName))
                    material.SetBuffer(propertyName, buffer);
                else
                    Debug.LogWarning($"Material '{material.name}' does not have property '{propertyName}' for ComputeBuffer.");
            }

            public static void WithColorArray(this Material material, string propertyName, Color[] colors)
            {
                if (material.HasProperty(propertyName))
                    material.SetColorArray(propertyName, colors);
            }

            public static void WithFloatArray(this Material material, string propertyName, float[] values)
            {
                if (material.HasProperty(propertyName))
                    material.SetFloatArray(propertyName, values);
            }

            public static void WithMatrixArray(this Material material, string propertyName, Matrix4x4[] matrices)
            {
                if (material.HasProperty(propertyName))
                    material.SetMatrixArray(propertyName, matrices);
            }

            public static void WithTextureArray(this Material material, string propertyName, Texture[] textures)
            {
                // NOTE: Only works with shaders that support texture arrays (sampler2DArray).
                if (material.HasProperty(propertyName))
                    material.SetTexture(propertyName, textures.Length > 0 ? textures[0] : null); // Simplified
                else
                    Debug.LogWarning($"Material '{material.name}' does not support texture arrays at '{propertyName}'.");
            }

            public static void WithVectorArray(this Material material, string propertyName, Vector4[] vectors)
            {
                if (material.HasProperty(propertyName))
                    material.SetVectorArray(propertyName, vectors);
            }
        }
    }
}
