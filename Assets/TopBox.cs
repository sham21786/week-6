using UnityEngine;
using System.Collections;

public class TopBox : MonoBehaviour {

    void DoMahThang()
    {
        StartCoroutine(lidClose());
    }

    IEnumerator lidClose()
    {
        for (int i = 0; i < 46; i++)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 4);
            yield return null;
        }
    }
}
