using UnityEngine;

public class IfStatements : MonoBehaviour
{

    public int a = 10;
    public int b = 4;
    public int c = 14;
    
    public string password = "1234";
    
    public bool canRun;
    
    void Start()
    {
        if (a + b != c)
        {
            print ("this is true");
        }

        if (password != "1234")
        {
            print("correct password");
        }

        if (!canRun)
        {
            print("we can run");
        }
    }
}
