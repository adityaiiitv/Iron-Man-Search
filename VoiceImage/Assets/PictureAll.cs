using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureAll : MonoBehaviour {

    public GameObject picPrefab;
    public Google google;
    public void DeleteOldPictures() {
        if (transform.childCount > 0)
        {
            foreach (Transform child in this.transform)
            {
                Destroy(child.gameObject);
            }
        }
    }

    public void CreateImages(List<string> urlList, int resultNum, Vector3 camFor)
    {
        int picNum = 1;
        Vector3 center = Camera.main.transform.position;
        foreach (string url in urlList)
        {
            Vector3 pos = GetPosition(picNum, resultNum, camFor);
            GameObject pic = Instantiate(picPrefab, pos, Quaternion.identity, this.transform);
            pic.GetComponent<PictureBehavior>().LoadImage(url);
            picNum++;
        }
    }

    Vector3 GetPosition(int picNum, int rowNum, Vector3 camForward)
    {
        Vector3 pos = Vector3.zero;
        if (picNum <= 5)
        {
            pos = camForward + new Vector3(picNum * -3, 0, rowNum * 3.5f);
        }
        else
        {
            pos = camForward + new Vector3((picNum % 5) * 3, 0, rowNum * 3.5f);
        }
        return pos;
    }
}
