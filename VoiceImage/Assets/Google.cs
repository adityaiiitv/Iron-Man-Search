using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Google : MonoBehaviour {

    public PictureAll picture;
    public Text button;
    public const string API_KEY = "AIzaSyB2UYcZxmSa5emAkC0Jn6K2M6dgOIbST2E";
    public void GetPicture()
    {
        StartCoroutine(PictureRoutine());
    }
    IEnumerator PictureRoutine()
    {
        button.transform.parent.gameObject.SetActive(false);
        string query = button.text;
        query = WWW.EscapeURL(query);
        picture.DeleteOldPictures();
        Vector3 cameraFor = Camera.main.transform.forward;

        int row = 1;
        for (int i = 1; i <= 60; i += 10)
        {
            string url = "https://www.googleapis.com/customsearch/v1?q=" + query + 
                "&cx=009668865991503601294%3A_sxge7nt22o&filter=1&num=10&searchType=image&start=" + i + "&fields=items%2Flink&key="+ API_KEY;
            WWW www = new WWW(url);
            yield return www;
            picture.CreateImages(ParseResponse(www.text), row, cameraFor);
            row++;
        } 
        yield return new WaitForSeconds(5f);
        button.transform.parent.gameObject.SetActive(true);
    }

    List<string> ParseResponse(string text)
    {
        List<string> urlList = new List<string>();
        string[] urls = text.Split('\n');
        foreach (string line in urls)
        {
            if (line.Contains("link"))
            {
                string url = line.Substring(12, line.Length - 13);
                if(url.Contains(".jpg") || url.Contains(".png"))
                {
                    urlList.Add(url);
                }
            }
        }
        return urlList;
    }
}
