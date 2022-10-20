using TwitterUCU;
namespace CompAndDel.Filters
{
    public class FilterTwitterShare : IFilter
    {
        TwitterImage twitterImage;
        string savingPath;
        public string twitterMessage{get; set;}
        public FilterTwitterShare(string twitterMessage, string savingPath)
        {
            this.twitterImage = new TwitterImage();
            this.savingPath = savingPath;
            this.twitterMessage = twitterMessage;
        }
        public IPicture Filter(IPicture picture)
        {
            PictureProvider pictureProvider = new PictureProvider();
            //guardo la foto
            pictureProvider.SavePicture(picture, savingPath);
            //uso el metodo de la api
            this.twitterImage.PublishToTwitter(twitterMessage, savingPath);
            return picture;
        }
    }
}