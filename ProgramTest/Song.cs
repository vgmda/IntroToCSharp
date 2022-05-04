using System;
namespace ProgramTest
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        //Global variable which can be accessed as a part of a Song class
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            //Increment the songCount everytime a new Song() object is created
            songCount++;

        }
    }
}

