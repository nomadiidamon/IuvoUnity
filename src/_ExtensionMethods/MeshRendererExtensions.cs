using System;
using UnityEngine;


namespace IuvoUnity
{
    namespace _ExtensionMethods
    {
        public static class MeshRendererExtensions
        {

            public static int GetSubMeshCount(this MeshRenderer renderer)
            {
                MeshFilter meshFilter = renderer.GetComponent<MeshFilter>();
                if (meshFilter != null && meshFilter.sharedMesh != null)
                {
                    return meshFilter.sharedMesh.subMeshCount;
                }
                return 0;
            }

            public static void EnsureDoubleSided(Mesh mesh)
            {
                // Flip normals for double-sided rendering
                Vector3[] normals = mesh.normals;
                for (int i = 0; i < normals.Length; i++)
                {
                    normals[i] = -normals[i]; // Invert the normals
                }
                mesh.normals = normals;

                // Optionally, flip the triangles to make them visible from both sides
                // This is not always needed but can help in certain cases
                int[] triangles = mesh.triangles;
                for (int i = 0; i < triangles.Length; i += 3)
                {
                    int temp = triangles[i];
                    triangles[i] = triangles[i + 1];
                    triangles[i + 1] = temp;
                }
                mesh.triangles = triangles;
            }


            public static void SetCulling(this MeshRenderer renderer, UnityEngine.Rendering.CullMode cullMode)
            {
                if (renderer != null && renderer.material != null)
                {
                    // Set the Cull mode to the specified value
                    renderer.material.SetInt("_Cull", (int)cullMode);
                }
                else
                {
                    Debug.LogError("MeshRenderer or material is missing!");
                }
            }


        }

    }
}