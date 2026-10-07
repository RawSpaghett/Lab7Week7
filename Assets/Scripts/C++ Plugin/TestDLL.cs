using UnityEngine;
using System.Runtime.InteropServices;

public class TestDLL : MonoBehaviour {
    // The imported function
    [DllImport("CPP_Sort", EntryPoint = "TestSort")]
    public static extern void TestSort(int [] a, int length);

        /*
    public int[] a;

    void Start() {
        TestSort(a, a.Length);
    }
    */
}