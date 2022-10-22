using System;
using System.Drawing;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FilterCognitiveFace : IFilter
    {
        string savingPath;
        CognitiveFace cognitiveFace;
        //public bool hasFoundFace;
        
        public FilterCognitiveFace(string savingPath)
        {
            this.cognitiveFace = new CognitiveFace(true, Color.GreenYellow);
            this.savingPath = savingPath;
           // this.hasFoundFace = false;
        }
        public IPicture Filter(IPicture picture)
        {
            PictureProvider pictureProvider = new PictureProvider();
            //guardo la foto
            pictureProvider.SavePicture(picture, savingPath);
            //uso el metodo de la api
            this.cognitiveFace.Recognize(savingPath);
            picture = pictureProvider.GetPicture("tmpFace.jpg");
            
            return picture;
        }
        
        /*public void FaceFound(CognitiveFace cogFace){

            if(cogFace.FaceFound){
                this.hasFoundFace = true;
            }
            else{
                this.hasFoundFace = false;
            }
        } */
    }
    
}