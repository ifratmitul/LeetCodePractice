using System.Text;
namespace LeetCodePractice
{
     public class FileReader
     {

          public void readFile()
          {
               string text = System.IO.File.ReadAllText(@"./file3.txt");
               string[] textSplit = text.Split(", ");
               var csv = new StringBuilder();
               foreach (var item in textSplit)
               {
                    var item2 = item.Replace('\'', '\"');
                    item2 = item2.Replace(" ", "");
                    csv.AppendLine(item2);

               }
               File.WriteAllText(@"./newFile.csv", csv.ToString());
          }
     }
}