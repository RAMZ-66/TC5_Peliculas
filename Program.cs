using System;
using System.Collections.Generic;

namespace TC5_Peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombresDePelicula = new List<string>();
            nombresDePelicula.Add("Toy Story");
            nombresDePelicula.Add("Bicentennial Man");
            nombresDePelicula.Add("Beetlejuice");
            nombresDePelicula.Add("Silence of the lambs");
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Aladdin");
            nombresDePelicula.Add("Aladdin");

            //HashSet no permite elementos duplicados

            HashSet<string> nombresDePeliculaSet = new HashSet<string>();
            nombresDePeliculaSet.Add("Toy Story");
            nombresDePeliculaSet.Add("Bicentennial Man");
            nombresDePeliculaSet.Add("Beetlejuice");
            nombresDePeliculaSet.Add("Silence of the lambs");
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Aladdin");
            nombresDePeliculaSet.Add("Aladdin");

            Console.WriteLine("Cant. de películas en nombreDePelicula: " + nombresDePelicula.Count);
            Console.WriteLine("Cant. de películas en nombreDePeliculaSet: " + nombresDePeliculaSet.Count);

            HashSet<Pelicula> peliculasSet = new HashSet<Pelicula>();
            peliculasSet.Add(new Pelicula("Bad Boys", 1995));
            peliculasSet.Add(new Pelicula("Bad Boys", 1983));
            peliculasSet.Add(new Pelicula("Aladdin", 1992)); //Son objetos diferentes, incluso si tienen atributos iguales
            peliculasSet.Add(new Pelicula("Aladdin", 1992));

            Console.WriteLine("Cant. de películas en peliculasSet" + peliculasSet.Count);

            Dictionary<string, string> nombresDePeliculasFavoritas = new Dictionary<string, string>();

            nombresDePeliculasFavoritas.Add("Pablo", "Titanic");
            nombresDePeliculasFavoritas.Add("Esteban", "The Fast and the Furious: Tokyo Drift");
            nombresDePeliculasFavoritas.Add("Octavio", "Barbie in the 12 Dancing Princesses");

            string nombrePeliculaFavoritaPablo = nombresDePeliculasFavoritas.GetValueOrDefault("Pablo");
            Console.WriteLine("nombrePeliculaFavoritaPablo: " + nombrePeliculaFavoritaPablo);
            string nombrePeliculaFavoritaRamiro = nombresDePeliculasFavoritas.GetValueOrDefault("Raniro");
            Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //null

            nombrePeliculaFavoritaRamiro = nombresDePeliculasFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");
            Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //(Ninguna))

            nombresDePeliculasFavoritas.Add("Ramiro", "Avatar");

            nombrePeliculaFavoritaRamiro = nombresDePeliculasFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");
            Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //Avatar

            // Uso real de obtener valores de un Dictionary
            if (nombresDePeliculasFavoritas.TryGetValue("María", out string nombreDePeliculaFavoritaMaria))
            {
                Console.WriteLine("nombrePeliculaFavoritaMaria: " + nombreDePeliculaFavoritaMaria);
            }
            else
            {
                Console.WriteLine("María no tiene película favorita");
            }
            

            // Lista
            Console.WriteLine("------------");
            Console.WriteLine("Lista");

            for(int i = 0; i < nombresDePelicula.Count; i++)
            {
                Console.WriteLine(nombresDePelicula[i]);
            }

            // HashSet
            Console.WriteLine("------------");
            Console.WriteLine("HashSet");
            // foreach: elemento in conjunto
            foreach (string nombreDePelicula in nombresDePeliculaSet)
            {
                Console.WriteLine(nombreDePelicula);
            }
           
            // Dictionary
            Console.WriteLine("------------");
            Console.WriteLine("Dictionary");
            // foreach: elemento in conjunto
            foreach (var key in nombresDePeliculasFavoritas.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in nombresDePeliculasFavoritas.Keys)
            {
                Console.WriteLine(value);
            }
            
            foreach (var key in nombresDePeliculasFavoritas.Keys)
            {
                Console.WriteLine(key + ":" + nombresDePeliculasFavoritas.GetValueOrDefault(key));
            }

        }
    }
}
