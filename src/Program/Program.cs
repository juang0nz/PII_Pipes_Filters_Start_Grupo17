using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejer1

            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"/home/apereira/Documentos/anthony_universidad/prog2_v2/PII_Pipes_Filters_Start_Grupo17/src/Program/beer.jpg");
            //crep omstamcoas de filtro
            IFilter filtro1 = new FilterNegative();
            IFilter filtro2 = new FilterGreyscale();

            //genero los pipes
            IPipe pipe3 = new PipeNull();
            IPipe pipe2 = new PipeSerial(filtro1, pipe3);
            IPipe pipe1 = new PipeSerial(filtro2, pipe2);

            //mando la imagen
            pipe1.Send(picture);
            provider.SavePicture(pipe1.Send(picture), @"/home/apereira/Documentos/anthony_universidad/prog2_v2/PII_Pipes_Filters_Start_Grupo17/src/Program/beer2.jpg");


            //ejer2
            //creo un filtro
            IFilter persistentFilter = new FilterPersistent(@"BlackWidowGrey.jpg");

            //creo la tuberia
            IPipe persistentPipe = new PipeSerial(persistentFilter, pipe2);
            pipe1 = new PipeSerial(greyFilter, persistentPipe);

            pictureProvider.SavePicture(pipe1.Send(picture), @"FinalResultExcercise2.jpg");




      }
    }
}
