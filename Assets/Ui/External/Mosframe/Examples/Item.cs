/**
 * item.cs
 * 
 * @author mosframe / https://github.com/mosframe
 * 
 */

namespace Mosframe {

    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;

    public class Item : UIBehaviour, IDynamicScrollViewItem 
    {
	    private readonly Color[] colors = new Color[] {
		    Color.cyan,
		    Color.green,
	    };

	    public Image icon;
	    public Text  title;
	    public Image background;

        public enum DirectionSignal
        {
            D_Right, D_Left, D_UpRight, D_UpLeft, D_G_Right, D_G_Left, D_G_Up, D_End, D_Start
        }

        public DirectionSignal dir = DirectionSignal.D_Right;

        public void onUpdateItem( int index/*, int di*/)
        {

            //this.title.text         = string.Format("Name{0:d3}", (index + 1) );
            //this.background.color   = this.colors[Mathf.Abs(index) % this.colors.Length];
            //this.icon.sprite        = Resources.Load<Sprite>( (Mathf.Abs(index) % 20 + 1).ToString("icon_00") );

           // dir = (DirectionSignal)di;

            SetDirectionSignals();
        }


        public void SetDirection(DirectionSignal dire)
        {
            dir = dire;
        }

        void SetDirectionSignals()
        {
            switch(dir)
            {
                case DirectionSignal.D_Right:
                    this.title.text = string.Format("Turn Right");
                    this.icon.sprite = Resources.Load<Sprite>("UI_Signal_CrossRight");

                    break;
                case DirectionSignal.D_Left:
                    this.title.text = string.Format("Turn Left");
                    this.icon.sprite = Resources.Load<Sprite>("UI_Signal_CrossLeft");

                    break;
                case DirectionSignal.D_UpRight:
                    this.title.text = string.Format("Cross Right");
                    this.icon.sprite = Resources.Load<Sprite>("UI_Signal_Right");

                    break;
                case DirectionSignal.D_UpLeft:
                    this.title.text = string.Format("Cross Left");
                    this.icon.sprite = Resources.Load<Sprite>("UI_Signal_Left");

                    break;
                case DirectionSignal.D_G_Right:
                    this.title.text = string.Format("Turn Right at the roundabout ");
                    this.icon.sprite = Resources.Load<Sprite>("UI_Signal_RoundRight");

                    break;
                case DirectionSignal.D_G_Left:
                    this.title.text = string.Format("Turn Left at the roundabout");
                    this.icon.sprite = Resources.Load<Sprite>("UI_Signal_RoundLeft");

                    break;
                case DirectionSignal.D_G_Up:
                    this.title.text = string.Format("Go straight at the roundabout");
                    this.icon.sprite = Resources.Load<Sprite>("UI_Signal_CrossRight");  // Maychange
                    

                    break;
                case DirectionSignal.D_End:
                    this.title.text = string.Format("End Route");
                    this.icon.sprite = Resources.Load<Sprite>("UI_Signal_RoundRight");

                    break;
                case DirectionSignal.D_Start:
                    this.title.text = string.Format("Start");
                    this.icon.sprite = Resources.Load<Sprite>("UI_Signal_Start");
       
                    break;

            }
        }
     




    }
}