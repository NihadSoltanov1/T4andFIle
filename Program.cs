using System.IO;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace T4andFileOperations;
public static class Program
{
    
    public static string[] GetEntitiesFromFile()
    {
        string filePath = @"C:\Users\Nihad Soltanov\Desktop\CodeAcademy\MyCodes\Tasks3\T4andFileOperations\Entities.txt";
        StreamReader reader = new StreamReader(filePath);
        string _entities = reader.ReadToEnd();


        string[] entities = _entities.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        return entities;
    }

    public static void CreateEntities()
    {
        string[] entities = GetEntitiesFromFile();
        string path = @"C:\Users\Nihad Soltanov\Desktop\CodeAcademy\MyCodes\Tasks3\T4andFileOperations\Models\";
        string filePath = "";
        foreach (string i in entities)
        {
            filePath = Path.Combine(path, i + ".cs");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("");
                writer.WriteLine("namespace T4andFileOperations.Models");
                writer.WriteLine("{");
                writer.WriteLine($"    public class {i}");
                writer.WriteLine("    {");
                writer.WriteLine("              ");
                writer.WriteLine("    }");
                writer.WriteLine("}");
            }
        }
        

        
    }


    public static void Main(string[] args)
    {
        CreateEntities();
    }
}