using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04Files
{
    class Files
    {
        static void Main(string[] args)
        {
            int numInputs = int.Parse(Console.ReadLine());
            Dictionary<string, List<File>> FileInfoDict = new Dictionary<string, List<File>>();
            while (numInputs > 0)
            {
                string[] command = Console.ReadLine().Split(new[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                File newFile = CreateNewFile(command);
                if (FileInfoDict.ContainsKey(command[0]))
                {// if there are key like the newFile.RootDir, then check 
                    if (FileInfoDict[command[0]].Any(f => f.Name.Equals(newFile.Name))) // if in the list there are file with that name.
                    {// check if that file has the same extension 
                        if (FileInfoDict[command[0]].First(f => f.Name.Equals(newFile.Name)).Extension.Equals(newFile.Extension))
                        {// then rewrite the latest info which is in the newFile
                            FileInfoDict[command[0]].First(f => f.Name.Equals(newFile.Name)).Size = newFile.Size;
                        }
                        else // if that file has different extension from that of the newFile
                        {// then that is different file and we add it to the list
                            FileInfoDict[command[0]].Add(newFile);
                        }
                    }
                    else
                    {// if in the list there are no file with that name, we add it to the list
                        FileInfoDict[command[0]].Add(newFile);
                    }
                }
                else
                {
                    FileInfoDict.Add(command[0], new List<File>());
                    FileInfoDict[command[0]].Add(newFile);
                }

                numInputs--;
            }
            string[] lastCommand = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (FileInfoDict.ContainsKey(lastCommand[2]))
            {
                if(FileInfoDict[lastCommand[2]].Any(f=>f.Extension.Equals(lastCommand[0])))
                {
                    foreach (var f in FileInfoDict[lastCommand[2]].OrderByDescending(f => f.Size).ThenBy(f => f.Name))
                    {
                        if (f.Extension.Equals(lastCommand[0]))
                        {
                            Console.WriteLine("{0} - {2} KB", f.Name, f.Extension, f.Size);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("No");
                }
                
            }
            else
            {
                Console.WriteLine("No");
            }


        }

        private static File CreateNewFile(string[] arrayInfo)
        {
            File newFile = new File()
            {
                Name = arrayInfo[arrayInfo.Length - 2],
                Size = double.Parse(arrayInfo[arrayInfo.Length - 1]),
                RootDir = arrayInfo[0]
            };
            string[] arrayForExt = newFile.Name.Split('.').ToArray();
            newFile.Extension = arrayForExt[arrayForExt.Length - 1];
            return newFile;
        }
    }
    public class File
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public double Size { get; set; }
        public string RootDir { get; set; }
    }
}