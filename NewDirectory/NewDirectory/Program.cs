using Directories;
using System.Drawing;

string folderName = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/Images";
if (!Directory.Exists(folderName))
{
    Directory.CreateDirectory(folderName);
}

string fileName = "numberCounter.txt";
string filePath = Path.Combine(folderName, fileName);
FileStream folder = new FileStream(filePath, FileMode.OpenOrCreate);
if (!File.Exists(filePath))
{
    File.Create(filePath);
}
folder.Dispose();


Bitmap image;
while (true)
{
    Console.WriteLine("Click Enter Button");
    var button = Console.ReadKey();
    if (button.Key == ConsoleKey.Enter)
    {
        image= new Bitmap(1920, 1200);
        Size size = new Size(image.Width, image.Height);

        using Graphics graphics = Graphics.FromImage(image);
        graphics.CopyFromScreen(0, 0, 0, 0, size);
        string imageName = "ScreenShot_" + Counter.Count(filePath).ToString()+".png";
        string imagePath = Path.Combine(folderName, imageName);
        image.Save(imagePath);
        Counter.IncreaseCount(filePath);
    }

}
