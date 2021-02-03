using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;
using System.Text;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string artist = tokens[0];
                string song = tokens[1];

                bool isArtistIsValid = true;
                bool isSongIsValid = true;


                if (isArtistIsValid)
                {
                    for (int i = 1; i < artist.Length; i++)
                    {
                        if (!char.IsUpper(artist[0]))
                        {
                            isArtistIsValid = false;
                        }
                        if (char.IsUpper(artist[i]))
                        {
                            isArtistIsValid = false;
                        }
                        if (!char.IsLetter(artist[i]))
                        {
                            if (!(artist[i] == '\'' || artist[i] == ' '))
                            {
                                isArtistIsValid = false;
                            }
                        }
                    }  
                }

                if (isSongIsValid)
                {
                    for (int i = 0; i < song.Length; i++)
                    {

                        if (char.IsLower(song[i]))
                        {
                            isSongIsValid = false;
                        }
                        if (!char.IsLetter(song[i]))
                        {
                            if (!(song[i] == ' '))
                            {
                                isArtistIsValid = false;
                            }
                        }
                    }
                }

                if (isArtistIsValid == false || isSongIsValid == false)
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;

                }

                string encryptedArtist = string.Empty;
                string encryptedSong = string.Empty;

                if (isArtistIsValid && isSongIsValid)
                {

                    int keyCount = artist.Length;

                    for (int i = 0; i < artist.Length; i++)
                    {
                        
                        char currentChar = (char)(artist[i] + keyCount);
                        if ((char)(artist[0] + keyCount) > 'Z')
                        {
                            currentChar -= (char)26;
                        }
                        else if ((char)(artist[i] + keyCount) > 'z')
                        {
                            currentChar -= (char)(26); 
                        }

                        if (artist[i] == ' ')
                        {
                            currentChar = ' ';
                        }
                        else if (artist[i] == '\'')
                        {
                            currentChar = '\'';
                        }
                        encryptedArtist += currentChar;
                        
                    }

                    for (int i = 0; i < song.Length; i++)
                    {
                        char currentChar = (char)(song[i] + keyCount);
                        if ((char)(song[i] + keyCount) > 'Z')
                        {
                            currentChar -= (char)26;
                        }
                        if (song[i] == ' ')
                        {
                            currentChar = ' ';
                        }
                        else if (song[i] == '\'')
                        {
                            currentChar = '\'';
                        }
                        encryptedSong += currentChar;
                    }
                }
                Console.WriteLine($"Successful encryption: {encryptedArtist}@{encryptedSong}");
                command = Console.ReadLine();
            }
        }
    }
}
