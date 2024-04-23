using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshCombiner : MonoBehaviour
{
    [SerializeField] private List<MeshFilter> listmeshfilt;
    [SerializeField] private MeshFilter meshfilt;

    public void CombineMeshes()
    {
        var combine = new CombineInstance[listmeshfilt.Count];

        for (var i = 0; i < listmeshfilt.Count; i++)
        {
            combine[i].mesh = listmeshfilt[i].sharedMesh;
            combine[i].transform = listmeshfilt[i].transform.localToWorldMatrix;
        }


        var mesh = new Mesh();
        mesh.CombineMeshes(combine);
        meshfilt.mesh = mesh;
    }

}
