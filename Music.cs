using System;
using System.Collections.Generic;
using System.Text;

namespace Music_Player.Classes
{
    public abstract class Music
    {
        public abstract int Rank(int rank_num);
        public abstract LinkedList<Type> Search(string name);
       // public abstract void Pause(string song);
        public abstract void VolumeUp();
        public abstract void VolumeDown();
        public abstract string UrlSong();
        public abstract string UrlPic();
        public abstract string ArtistName();
    }
}
