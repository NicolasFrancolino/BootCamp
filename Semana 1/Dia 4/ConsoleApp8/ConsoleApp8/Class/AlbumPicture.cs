using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Class
{
    public class AlbumPicture
    {
        public int numPages;

        public AlbumPicture()
        {
            numPages = 16;
        }
        public AlbumPicture(int numPages)
        {
            this.numPages = numPages;
        }
        public int GetNumberPages() => numPages;
    }
}
