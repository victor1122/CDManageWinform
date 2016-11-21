using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDManagementWinform
{
    public class CDInformation
    {
        string ID, Album, Singer, Genre;
        int duration;
        List<String> song = new List<string>();

        public CDInformation(string iD, string album, string singer, string genre, int duration)
        {
            ID = iD;
            Album = album;
            Singer = singer;
            Genre = genre;
            this.duration = duration;
        }

        #region GetSet
        public string ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string Album1
        {
            get
            {
                return Album;
            }

            set
            {
                Album = value;
            }
        }

        public string Singer1
        {
            get
            {
                return Singer;
            }

            set
            {
                Singer = value;
            }
        }

        public string Genre1
        {
            get
            {
                return Genre;
            }

            set
            {
                Genre = value;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        public List<string> Song
        {
            get
            {
                return song;
            }

            set
            {
                song = value;
            }
        }
        #endregion
    }
}
