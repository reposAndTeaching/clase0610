using System;
using System.Collections.Generic;
//using System.Collections.Generic;

namespace clase0610
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar
            List<string> listaCarreras;
            //inicializamos
            listaCarreras = new List<string>();

            //en lugar de length, en List es Count
            Console.WriteLine(listaCarreras.Count);
            //Añadimos con Add
            listaCarreras.Add("Ingeniería en Informática");
            Console.WriteLine(listaCarreras.Count);
            //Añadimos elementos en un índice específico
            listaCarreras.Insert(0, "Ingeniería en Química");

            //usamos foreach para recorrer la lista
            foreach(string carrera in listaCarreras)
            {
                Console.WriteLine(carrera);
            }

            listaCarreras.Insert(2, "Educación Parvularia");

            foreach (string carrera in listaCarreras)
            {
                Console.WriteLine(carrera);
            }
            Console.WriteLine("***");
            Console.WriteLine(listaCarreras[0]);
            Console.WriteLine(listaCarreras[1]);
            Console.WriteLine(listaCarreras[2]);

            listaCarreras[0] = "Ingeniería en Aeronautica";
            //No podemos pasar por sobre como está estructurado este tipo de dato
            //Si no tiene el elemento indicado (en este caso por el index), no podemos acceder ni modificar
            //listaCarreras[3] = "Ingeniería en Matemáticas";

            Console.WriteLine("***");
            Console.WriteLine(listaCarreras[0]);
            Console.WriteLine(listaCarreras[1]);
            Console.WriteLine(listaCarreras[2]);

            Console.WriteLine("***");

            //declaro un nuevo diccionario/dictionary
            Dictionary<string, int> stockDeFrutas;

            stockDeFrutas = new Dictionary<string, int>();
            stockDeFrutas.Add("Manzana", 10);
            stockDeFrutas.Add("Frutilla", 5);

            Console.WriteLine(stockDeFrutas.Count);

            foreach(var fruta in stockDeFrutas)
            {
                Console.WriteLine(fruta);
                if(fruta.Key == "Frutilla")
                {
                    Console.WriteLine("La {0} tiene un stock de {1}", fruta.Key, fruta.Value);
                }
            }

            foreach(var elem in stockDeFrutas.Keys)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine(stockDeFrutas["Manzana"]);

            bool retorno = stockDeFrutas.TryAdd("Naranja", 78);
            Console.WriteLine(retorno);


            Console.WriteLine("******************");
            //Creamos una Cola (Queue)
            Queue<int> colaDeNumeros = new Queue<int>();

            //con Enqueue agregamos elementos al final de la cola
            colaDeNumeros.Enqueue(1);
            colaDeNumeros.Enqueue(2);
            colaDeNumeros.Enqueue(3);

            Console.WriteLine("Cola de números");
            foreach (int elem in colaDeNumeros)
            {
                
                Console.WriteLine(elem);
            }

            //con Dequeue quitamos el primer elemento de la cola(Peek()) y lo retorna
            var algo = colaDeNumeros.Dequeue();
            Console.WriteLine(algo);

            Console.WriteLine("Cola de números");
            foreach (int elem in colaDeNumeros)
            {
                
                Console.WriteLine(elem);
            }

            Console.Write("Próximo elemento en salir de la cola: ");
            //próximo elemento a quitar por Dequeue es Peek()
            Console.WriteLine(colaDeNumeros.Peek());

            //Crear una pila (Stack)

            Console.WriteLine("*************************");
            Stack<Pelicula> pilaDePeliculas = new Stack<Pelicula>();
            Pelicula p1 = new Pelicula("Avengers", 2012);
            Pelicula p2 = new Pelicula("Spider-Man", 2002);

            //Con push agregamos elementos sobre la pila
            pilaDePeliculas.Push(p1);
            pilaDePeliculas.Push(p2);
            pilaDePeliculas.Push(new Pelicula("Iron-Man", 2008));

            Console.WriteLine("Listamos la pila");
            foreach(Pelicula elem in pilaDePeliculas)
            {
                Console.WriteLine(elem.Nombre);
            }

            //con pop quitamos elemento de sobre la pila (Peek())
            Pelicula primeraEnSalir = pilaDePeliculas.Pop();

            Console.WriteLine("Película retirada de la pila");
            Console.WriteLine(primeraEnSalir.Nombre);
            Console.WriteLine("Listamos la pila");
            foreach (Pelicula elem in pilaDePeliculas)
            {
                Console.WriteLine(elem.Nombre);
            }

            Console.WriteLine("***Excepciones***");
            //EXCEPCIONES

            //creamos una lista de string
            List<string> nombres = new List<string>();
            Console.WriteLine("Agregando nombres a la lista");
            nombres.Add("Javier");
            nombres.Add("Henrietta");
            nombres.Add("Juana");

            Console.Write("Ingrese elemento a visualizar: ");
            //int indice = Convert.ToInt32(Console.ReadLine());
            int indice = 0;

            Console.WriteLine("Cambiando nombre al índice establecido");
            //ArgumentOutOfRangeException
            try
            {
                Console.WriteLine(nombres[indice]);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("No se puede acceder al índice establecido");
            }

            Console.WriteLine("He continuado con la ejecución del programa sin caerme");


            Console.WriteLine("***");

            Fraccion nuevaFraccion = new Fraccion(4, 2);
            Console.WriteLine(nuevaFraccion.Numerador);
            Console.WriteLine(nuevaFraccion.Denominador);

            Console.WriteLine(nuevaFraccion.ValorDeLaFracción());

            Fraccion nuevaFraccion2 = new Fraccion(4, 0);
            Console.WriteLine(nuevaFraccion2.Numerador);
            Console.WriteLine(nuevaFraccion2.Denominador);

            Console.WriteLine(nuevaFraccion2.ValorDeLaFracción());
        }
    }
}
