using System.IO;

namespace CopyDirectory
{
    public class Program
    {
        public static readonly string INPUT_DIRECTORY = Path.Combine(Directory.GetCurrentDirectory(), "input");     
        //입력 폴더와 출력 폴더
        public static readonly string OUTPUT_DIRECTORY = Path.Combine(Directory.GetCurrentDirectory(), "output");   
        //입력 폴더 안에 있는 컨텐츠들을 출력 폴더로 복사할 것임

        public static void Main(string[]args)
        {
            cleanDirectory(OUTPUT_DIRECTORY);   
            //출력 디렉토리를 지운다. 우리만의  delete 재귀함수를 만듦.  
            //다 지우고 새로 시작하는 것이 좋기에 이 방법을 선택함

            if (!Directory.Exists(OUTPUT_DIRECTORY)) //만약 디렉터리가 없다면 
            {
                Directory.CreateDirectory(OUTPUT_DIRECTORY);    //디렉터리를 만듦    
            }
            copyDirectory(INPUT_DIRECTORY, OUTPUT_DIRECTORY);   //입력 디렉터리를 출력 디렉터리에 복사
            }

            private static void copyDirectory(string sourcePath, string destPath)   //copyDirectory 함수 사용
            {
                var files = Directory.GetFiles(sourcePath); 
                //sourcePath에 있는 모든 파일을 가져온다. 이것은 하위 폴더에 있는 파일 까지 가져오지 않는다

                foreach(var file in files)  //각 파일을 destPath로 복사
                {
                    var fileName = Path.GetFileName(file);  
                    //file은 절대 경로이기 때문에 여기서 파일이름만 추출해서 destPath에 덧붙임
                    File.Copy(file, Path.Combine(destPath, fileName));
                }

                var directories = Directory.GetDirectories(sourcePath); 
            //모든 하위 디렉터리를 가져온다, 하위 디렉터리 안에 있는 다른 하위 디렉터리들을 가져오지는 않는다.

                foreach (var directory in directories)  //각 하위 디렉터리를 순회
                {
                    var dest = directory.Replace(sourcePath, destPath); 
                    //directory는 절대경로 이기때문에 
                    //복사될 하위디렉터리의 전체 경로를 가져오기 위해서는 directory에서 sourcePath를 destPath로 바꿔야 한다
                    
                    Directory.CreateDirectory(dest);    
                    //dest안에 새로운 디렉터리를 생성

                    copyDirectory(directory, dest); 
                    //각 하위 디렉터리마다 그 속에 들어있는 파일과 하위 디렉터리들을 복사해야한다
                }
            }

        private static void cleanDirectory(string path)
        {
            if(Directory.Exists(path))  //디렉토리가 있는지 검색  디렉토리가 없으면 함수 제일 밑으로 빠져나옴
            {
                string[] files = Directory.GetFiles(path);  //디렉토리가 존재하면 그 디렉터리 안에 있는 파일을 지워야 함     파일 목록을 가져옴

                foreach (string filepath in files)  //파일 목록을 순회하면서 각 파일을 지움
                {
                    File.Delete(filepath);
                }

                string[] directories = Directory.GetDirectories(path);  //하위 디렉터의 목록을 가져온다

                foreach (string directorypath in directories)   
                //각 하위 디렉터도 파일과 또 다른 하위 디렉터를 가지고 있을 수 있다. 
                //따라서 각 하위 디렉터 마다 cleanDirectory함수를 호출한다.
                {
                    cleanDirectory(directorypath);
                }

                Directory.Delete(path); //출력 폴더를 다 지움 
            }
        }
    }
}
