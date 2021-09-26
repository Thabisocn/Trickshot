using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opentwitter : MonoBehaviour
{
    public void Opentwitterapp()
    {
        Application.OpenURL("https://twitter.com/io_nextgen");
    }

    public void Openfacebookapp()
    {
        Application.OpenURL("https://www.facebook.com/NextGen-IO-103551498358997");
    }

     public void Openwebsite()
    {
        Application.OpenURL("https://nextgen-io.com/");
    }
}
