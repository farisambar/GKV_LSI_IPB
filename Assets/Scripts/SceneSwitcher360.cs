using UnityEngine;

public class SceneSwitcher360 : MonoBehaviour
{
    public Transform xrOrigin;

    public Transform jalanDepan;
    public Transform depanGedungB;
    public Transform depanGedungA;

    public void GoToJalanDepan()
    {
        xrOrigin.position = jalanDepan.position;
        xrOrigin.rotation = Quaternion.identity;
    }

    public void GoToDepanGedungB()
    {
        xrOrigin.position = depanGedungB.position;
        xrOrigin.rotation = Quaternion.identity;
    }

    public void GoToDepanGedungA()
    {
        xrOrigin.position = depanGedungA.position;
        xrOrigin.rotation = Quaternion.identity;
    }
}