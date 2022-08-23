using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Music_Player.Classes
{
    public class Pop :  Music
    {
        /// <summary>
        /// functions of the class Pop
        /// </summary>
        private string[] lines = System.IO.File.ReadAllLines(@"C:\Users\dikla\OneDrive\שולחן העבודה\לימודים מדמח HIT\שנה א\קיץ\מונחה\Final Project\Pop_Songs\Songs.txt");
        private int i = 0,j=0;
        public Pop() {
            for(i=0;i<lines.Length-3;i=i+4)
            {
                if(songs.First==null)
                {
                    this.artist = lines[i];
                    this.nameSong = lines[i + 1];
                    this.pic_song = lines[i + 2];
                    this.urlSong = lines[i + 3];
                    songs.AddFirst(this);
                }
                else
                {
                    this.artist = lines[i];
                    this.nameSong = lines[i + 1];
                    this.pic_song = lines[i + 2];
                    this.urlSong = lines[i + 3];
                    songs.AddLast(this);
                }
            }
            i = 0;
        }
        public override string UrlSong()
        {
            if (i == 0)
            {
                string s = lines[i + 3];
                i=i+4;
                return s;
            }
            else if (i < lines.Length)
            {
                string s = lines[i + 3];
                i=i+4;
                return s;
            }
            else
            { 
                i = 0;
                string s = lines[i + 3];
                return s;
            }

        }

        //public override void Pause(string song)
        //{
        //    Console.WriteLine("hey");
        //}
        public override string UrlPic()
        {
            if (j == 0)
            {
                string s = lines[j + 2];
                j = j + 4;
                return s;
            }
            else if (j < lines.Length)
            {
                string s = lines[j + 2];
                j = j + 4;
                return s;
            }
            else
            {
                j = 0;
                string s = lines[j + 2];
                return s;
            }
        }
        public override string ArtistName()
        {
            return Artist;
        }
        public override int Rank(int rank_num)
        {
            throw new NotImplementedException();
        }

        public override LinkedList<Type> Search(string name)
        {
            throw new NotImplementedException();
        }
        public override void VolumeDown()
        {
            throw new NotImplementedException();
        }

        public override void VolumeUp()
        {
            throw new NotImplementedException();
        }
        //public void UpLoadSongs(Pop p)
        //{
        //    /*פותחים את התיקייה של השירים
        //     בודקים אם זה שיר חדש 
        //  מוסיפים*/
        //    Songs.AddLast(p);
        //}
        //public void DeleteSong(Pop p)
        //{
        //    //פותחים את התיקייה בודקים מה השיר שרוצים למחוק ועושים מחיקה
        //     Songs.Remove(Songs.Find(p));
        //}
        /// <summary>
        /// Properties of the class
        /// </summary>
        private string currSong=null;
        public string CurrSong
        {
            get { return currSong; }
            set { currSong = value; }
        }
        private string nameSong=null;
        public string NameSong
        {
            get { return nameSong; }
            set { nameSong = value; }
        }
        private string artist = null;
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private string pic_song = null;
        //public string PicSong
        //{
        //    get { return pic_song; }
        //    set { pic_song = value; }
        //}
        private string urlSong = null;
        //public string URLSong
        //{
        //    get { return urlSong; }
        //    set { URLSong = value; }
        //}
        private int index_in_file;
        private LinkedList<Pop> songs = new LinkedList<Pop>();
        public LinkedList<Pop> Songs
        {
            get { return songs; }
            //set is a function of the maneger not the user.
        }
    }
}
