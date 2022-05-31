using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");


            //IMPORTANTE: Se implementa el proceso al revés de como aparece en el diagrama!!!
            IPipe pipenull = new PipeNull();
            IFilter negativo = new FilterNegative(); 
            IPipe pipe2 = new PipeSerial(negativo, pipenull);
            IFilter gris = new FilterGreyscale();
            IPipe pipe1 = new PipeSerial(gris, pipe2);

            picture= pipe1.Send(picture);           

            provider.SavePicture(picture, @"beermodificado.jpg");

            }
           // IPicture picture = provider.SavePicture("PathToNewImage.jpg");

           IFilter persistFilter = new 

        }
    }
}
