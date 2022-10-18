namespace CompAndDel.Filters
{
   public class FilterPersistent : IFilter
   {
      private PictureProvider pictureProvider;
      private string pathToPersist;
      public FilterPersistent(string pathToPersist)
      {
         this.pathToPersist = pathToPersist;
         pictureProvider = new PictureProvider();
      }
      public IPicture Filter(IPicture picture)
      {
         this.pictureProvider.SavePicture(picture, pathToPersist);
         return picture;
      }
   }
}