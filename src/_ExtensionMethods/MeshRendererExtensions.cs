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

        }

    }
}