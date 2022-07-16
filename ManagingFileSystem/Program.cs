namespace ManagingFileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Yamini\yam\Learn\fs";
            // folders
            //string[] dirs = Directory.GetDirectories(rootPath,"*", SearchOption.AllDirectories);
            //foreach(string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            // files
            //string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            //foreach (string file in files)
            //{
            //    //Console.WriteLine(file);
            //    //Console.WriteLine(Path.GetFileName(file));
            //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    //Console.WriteLine(Path.GetDirectoryName(file));
            //    var info = new FileInfo(file);
            //    Console.WriteLine($"{info.Length} bytes - {info.Directory} - {info.DirectoryName} " +
            //        $"- {info.Name} - {info.FullName}-{info.LastWriteTime} - {info.LastAccessTime} - {info.Extension}");
            //}

            string path = Path.Combine(rootPath, "A", "B");
            bool exists = Directory.Exists(path);
            if (!exists)
            {
                Console.WriteLine("Not exists");
                Directory.CreateDirectory(path);
                Console.WriteLine("created");
            }
            else
            {
                Console.WriteLine("Exists");
            }


            Console.ReadLine();
        }
    }
}