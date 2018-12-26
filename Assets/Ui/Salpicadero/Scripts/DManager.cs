
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class DManager : MonoBehaviour
{
    public Texture2D[] Signals; //pick all kind of signals
    [Space]
    public RectTransform prefap;
    public Text countText;
    public ScrollRect scrowview;

    public RectTransform content;

    
    List<Itmview> views = new List<Itmview>();



    void Start () {
		
	}
	
    public void UpdateItems()
    {
        int newCount = 0;
        int.TryParse(countText.text, out newCount);
        StartCoroutine(ItmGet(newCount, results=> OnRecievedPrefaps(results)));
    }

    void OnRecievedPrefaps(Signal[] prefaps)
    {

        foreach (Transform child in content)
            Destroy(child.gameObject);

        views.Clear();

        int i = 0;
        foreach (var prefapp in prefaps)
        {
            var instance = GameObject.Instantiate(prefap.gameObject) as GameObject;
            instance.transform.SetParent(content, false);

           var view = InitializeItmView(instance, prefapp);
            views.Add(view);
            ++i;
        }
    }

    Itmview InitializeItmView(GameObject VgameObject, Signal model)
    {
        Itmview view = new Itmview(VgameObject.transform);

        view.title.text = model.name;
        view.Signal.texture = Signals[model.typesignal];

        return view;

    }

    IEnumerator ItmGet(int count , Action<Signal[]> onDone)
    {
        yield return new WaitForSeconds(2f); // every 2 segs  if is in server delete this

        var results = new Signal[count];

        for (int i = 0; i < count; ++i)
        {
            results[i] = new Signal();
            results[i].name = i.ToString() + "km "; // cold be the km to destino 

            results[i].typesignal = UnityEngine.Random.Range(0, Signals.Length);
                        //will change in the next signal, maybe it heredate the signal from next signal
                        // delete random, but needs to be "establecido" a order of signals
        }

        onDone(results);
    }
    public class Signal
    {
        public string name;
        public int typesignal; // 0= stoped
    }
    public class Itmview
    {

        public Text title;
        public RawImage Signal;

        public Signal Model
        {
            set
            {
                if (value != null)
                    title.text = value.name;
            }
        }

        public Itmview(Transform rootV)
        {
            title = rootV.Find("DirectionPrefap/FAP_text").GetComponent<Text>();
            Signal = rootV.Find("DirectionPrefap/FAP_img_Back").GetComponent<RawImage>();
        }
     
    }


}
