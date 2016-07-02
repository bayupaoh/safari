using UnityEngine;
using System.Collections;
using Vuforia;

public class TekkenVirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    
    void Start()
    {
        
        // Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }
        //objectDori.GetComponent<SpriteRenderer> ().sprite = spriteDori;
    }
    void Update()
    {
   
       

    }

    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) { }

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
 


        switch (vb.VirtualButtonName)
        {

            case "btnMasakRendang":
                Application.OpenURL("http://tanahairku.web.id/video/41");
                break;
            case "btnMasakCoto":
                Application.OpenURL("http://tanahairku.web.id/video/71");
                break;
            case "btnMasakBose":
                Application.OpenURL("http://tanahairku.web.id/video/51");
                break;
            case "btnMasakPindang":
                Application.OpenURL("http://tanahairku.web.id/video/61 ");
                break;
            case "btnMasakKaredok":
                Application.OpenURL("http://tanahairku.web.id/video/81");
                break;
            case "btnTarianJaipong":
                Application.OpenURL("http://tanahairku.web.id/video/1");
                break;
            case "btnTarianJambi":
                Application.OpenURL("http://tanahairku.web.id/video/11");
                break;
            case "btnTarianPakarena":
                Application.OpenURL("http://tanahairku.web.id/video/31");
                break;
            case "btnTariPiring":
                Application.OpenURL("http://tanahairku.web.id/video/7");
                break;
            case "btnTarianNtt":
                Application.OpenURL("http://tanahairku.web.id/video/21");
                break;
            case "btnHPSumbar":
                Application.OpenURL("http://www.sumbarprov.go.id");
                break;
            case "btnHPSulsel":
                Application.OpenURL("http://www.sulselprov.go.id");
                break;
            case "btnHPNtt":
                Application.OpenURL("http://www.nttprov.go.id");
                break;
            case "btnHPJambi":
                Application.OpenURL("http://www.jambiprov.go.id");
                break;
            case "btnHPJabar":
                Application.OpenURL("http://www.jabarprov.go.id");
                break;
            case "triviasumbar":
                Application.OpenURL("http://www.jabarprov.go.id");
                break;
           
            default:
                throw new UnityException("Button not supported: " + vb.VirtualButtonName);

        }
    }
}
