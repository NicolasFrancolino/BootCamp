using ConsoleApp8.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class AlbumPicturetest
    {
        static void Main(string[] args)
        {
            AlbumPicture myAlbum = new AlbumPicture();  
            Console.WriteLine(myAlbum.GetNumberPages());
            AlbumPicture myAlbum1 = new AlbumPicture(24);  
            Console.WriteLine(myAlbum1.GetNumberPages());
            SuperAlbumPicture myBigAlbum = new SuperAlbumPicture();  
            Console.WriteLine(myBigAlbum.GetNumberPages());
            Console.ReadKey();
        }
        
        
    }
}

