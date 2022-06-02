
class Program
{
    static void Main(string[] args)
    {
        List<String> mov = new List<String>();
        List<String> sub = new List<String>();

        string dir = System.IO.Directory.GetCurrentDirectory();

        string[] subs = System.IO.Directory.GetFiles(dir, "*.srt");
        string[] movs = System.IO.Directory.GetFiles(dir, "*.mov");
        string[] mkvs = System.IO.Directory.GetFiles(dir, "*.mkv");
        string[] mp4s = System.IO.Directory.GetFiles(dir, "*.mp4");

        for (int i = 0; i < subs.Length; i++) {
            subs[i] = subs[i].Replace(dir, "");
            subs[i] = subs[i].Replace(".srt", "");
        }

        if (movs.Length > 0) {
            for (int i = 0; i < movs.Length; i++)
            {
                movs[i] = movs[i].Replace(dir, "");
                movs[i] = movs[i].Replace(".mov", "");
            }
            for (int i = 0; i < subs.Length; i++)
            {
                System.IO.File.Move(dir + subs[i] + ".srt", dir + movs[i] + ".srt");

            }
        }
        else if (mp4s.Length > 0)
        {
            for (int i = 0; i < mp4s.Length; i++)
            {
                mp4s[i] = mp4s[i].Replace(dir, "");
                mp4s[i] = mp4s[i].Replace(".mp4", "");
            }
            for (int i = 0; i < subs.Length; i++)
            {
                System.IO.File.Move(dir + subs[i] + ".srt", dir + mp4s[i] + ".srt");

            }
        }
        else if(mkvs.Length > 0)
        {
            for (int i = 0; i < mkvs.Length; i++)
            {
                mkvs[i] = mkvs[i].Replace(dir, "");
                mkvs[i] = mkvs[i].Replace(".mkv", "");
            }
            for (int i = 0; i < subs.Length; i++)
            {
                System.IO.File.Move(dir + subs[i] + ".srt", dir + mkvs[i] + ".srt");

            }
        }



    }
}



