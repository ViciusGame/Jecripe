using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class JanelaButton : MonoBehaviour
{
    public MusicaInsideController mc;
    public MusicaAudioController mac;
    private bool enabledButton;
    public Ray ray;
    public Transform highlight;
    public Transform highlight2;

    public virtual void OnMouseDown()
    {
        if (this.enabledButton)
        {
            this.mac.ResetAndStopPlay();
            switch (this.name)
            {
                case "Janela1Button":
                    this.StartCoroutine(this.mc.Janela1Clicked());
                    break;
                case "Janela2Button":
                    this.StartCoroutine(this.mc.Janela2Clicked());
                    break;
                case "Janela3Button":
                    this.StartCoroutine(this.mc.Janela3Clicked());
                    break;
                case "Janela4Button":
                    this.StartCoroutine(this.mc.Janela4Clicked());
                    break;
                case "Janela5Button":
                    this.StartCoroutine(this.mc.Janela5Clicked());
                    break;
                case "Janela6Button":
                    this.StartCoroutine(this.mc.Janela6Clicked());
                    break;
            }
        }
    }

    private Outline outline;
    private Outline outline2;
    private GameController gc;

    public void Start()
    {
        outline = highlight.gameObject.AddComponent<Outline>();
        highlight.gameObject.GetComponent<Outline>().OutlineColor = Color.magenta;
        highlight.gameObject.GetComponent<Outline>().OutlineWidth = 10.0f;
        outline2 = highlight2.gameObject.AddComponent<Outline>();
        highlight2.gameObject.GetComponent<Outline>().OutlineColor = Color.magenta;
        highlight2.gameObject.GetComponent<Outline>().OutlineWidth = 10.0f;
        outline.enabled = false;
        outline2.enabled = false;
    }

    public void Update()
    {
        if (!enabledButton)
        {
            outline.enabled = false;
            outline2.enabled = false;
        }

    }


    public virtual void OnMouseEnter()
    {
        
        outline.enabled = true;
       
        outline2.enabled = true;
       
    }

    public virtual void OnMouseExit()
    {
        outline.enabled = false;
        outline2.enabled = false;
    }

    public virtual void EnableButton(bool _state)
    {
        this.enabledButton = _state;
    }

}