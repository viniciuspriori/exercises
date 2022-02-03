using System;
using System.IO;
using System.Threading;

public class Manager{

        private readonly string PDF_FOLDER = Constants.PDF_Folder;
        private readonly string IMG_FOLDER = Constants.Images_Folder;
        private readonly string[] downloadFiles;
        public string FilePath { get; set; }

        public Manager(string filepath)
        {
            FilePath = filepath;
            downloadFiles = Directory.GetFiles(FilePath);
            Start();
        }

        public void Start()
        {
            foreach (var file in downloadFiles)
            {
                if(IsPDF(Path.GetExtension(file))) MoveFiles(file, PDF_FOLDER);
                if(IsIMG(Path.GetExtension(file))) MoveFiles(file, IMG_FOLDER);             
            }
             
             Thread.Sleep(1000);
             
        }
        private void MoveFiles(string file, string folderToMove)
        {
            
            if(!Directory.Exists(folderToMove)) Directory.CreateDirectory(folderToMove);

            var fileName = Path.GetFileName(file);
            var pathToMove = Path.Combine(folderToMove, fileName); 
            try { File.Move(file, pathToMove); }
            catch(FileNotFoundException){ throw; }

        }
        public static bool IsPDF(string extension) => extension == ".pdf";
        public static bool IsIMG(string extension) => (extension == ".jpg" || extension == ".png");
        
    }
