using System;
using System.Drawing;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FilterCognitiveFace : IFilter
    {
        string savingPath;
        
        public FilterCognitiveFace(string twitterMessage, string savingPath)
        {
            this.savingPath = savingPath;
            
        }
        public IPicture Filter(IPicture picture)
        {
            PictureProvider pictureProvider = new PictureProvider();
            //guardo la foto
            pictureProvider.SavePicture(picture, savingPath);
            //uso el metodo de la api

            return picture;
        }
    }
}