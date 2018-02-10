public class TakeScreenshot : MonoBehaviour
{
    // Fields
    private int screenshotCount;

    // Methods
    private void Update()
    {
        if (Input.GetKeyDown("f9"))
        {
            string str;
            do
            {
                this.screenshotCount++;
                str = "screenshot" + this.screenshotCount + ".png";
            }
            while (File.Exists(str));
            Application.CaptureScreenshot(str);
        }
    }
}
 
