using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    internal class Files
    {
        static void Main(string[] args)
        {
            //Write();
            //Read();
            //Append();
            //Thread.Sleep(5000);
            //Read();
            //FileExists();
            FilesDirectoriesDemo();
            Console.ReadLine();

        }
        public static void Write()
        {
            FileInfo fileInfo = new FileInfo(@"E:\Dlithe.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("Welcome to files");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }
        }
        public static void Read()
        {
            FileInfo fileInfo = new FileInfo(@"E:\Dlithe.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string line;
                line = reader.ReadToEnd();
                Console.WriteLine(line);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }
        }
        public static void Append()
        {
            FileInfo fileInfo = new FileInfo(@"E:\Dlithe.txt");
            FileStream fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("Appended content into the file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }
        }

        public static void FileExists()
        {
            string path = @"E:\Dlithe1.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public static void FilesDirectoriesDemo()
        {
            //File.WriteAllText(@"E:\Dlithe1.txt","I am a one line File Write Method");

            FileInfo fileInfo = new FileInfo(@"E:\Dlithe1.txt");
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(fileInfo.CreationTime);
            Console.WriteLine(fileInfo.LastAccessTime);
            Console.WriteLine(fileInfo.LastWriteTime);
            Console.WriteLine(fileInfo.Extension);
            Console.WriteLine("******************************");
            foreach (string files in Directory.GetFiles(@"E:\CG-VAK\.NET FULLSTACK\C#\C# Theory"))
            {
                Console.WriteLine(files);

            }
            Console.WriteLine("******************************");
            foreach(string files in Directory.GetDirectories(@"E:\CG-VAK\.NET FULLSTACK\C#"))
            {
                Console.WriteLine($"{files}");
            }
        }

    }

}
