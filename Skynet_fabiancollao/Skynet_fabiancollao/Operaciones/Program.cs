using AdminTerminator_ClassLibrary.DAL;

namespace Skynet_fabiancollao
{
    public partial class Program
    {
        static EliminadorDAL eliminadoresDAL = new EliminadorDAL();
        static void IngresarTerminator()
        {
            //Declaracion de atributos
            string num_serie;
            string tipo;
            Int32 destino;
            string objetivo;
            int prioridad;

            Console.Clear();
            imprimirAscii();
            rojo("               BIENVENIDO A SKYNET");
            Console.WriteLine();
            bool esValido=false;

            //Numero de serie
            do
            {
                textoTitulo("Ingrese numero de serie :");
                num_serie = Console.ReadLine().Trim();
                if (num_serie.Length==7)
                {
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("Debe tener 7 caracteres");
                    esValido = false;
                }
            } while (!esValido||num_serie.Equals(string.Empty));

            //Tipo
            do
            {
               textoTitulo("Ingrese Tipo(Modelo) :");
                Console.WriteLine(@"a) T-1
b) T-800
c) T-1000
d) T-3000");
                switch (Console.ReadLine().Trim().ToLower())
                {
                    case "a": tipo = "T-1"; esValido = true;
                        break;
                    case "b": tipo = "T-800"; esValido = true;
                        break;
                    case "c": tipo = "T-1000"; esValido = true;
                        break;
                    case "d": tipo = "T-3000"; esValido = true;
                        break;
                    default:
                        tipo = string.Empty;
                        Console.WriteLine("Ingresa bien una opción");
                        esValido = false;
                        break;
                }
            } while (!esValido);

            //Objetivo y prioridad
            do
            {
                textoTitulo("Ingrese objetivo:");
                objetivo = Console.ReadLine().Trim().ToLower();
                switch (objetivo)
                {
                    case "pedro gaete":prioridad = 1;
                        break;
                    case "john connor":prioridad = 2;
                        break;
                    case "sara connor":prioridad = 3;
                        break;
                    case "kyle reese":prioridad = 4;
                        break;
                    case "fabian collao": prioridad= 5;
                        break;
                    default: prioridad = 999;
                        break;
                }
            } while (objetivo.Equals(string.Empty));

            //Destino
            do
            {
                textoTitulo("Ingrese año de destino");
                esValido = Int32.TryParse(Console.ReadLine().Trim(), out destino);
                if(destino >=1997 && destino <=3000)
                {
                    esValido = true;
                }
                else
                {
                    esValido = false;
                    rojo("Debe estar entre 1997 y 3000");
                    Console.WriteLine();
                }
            } while (!esValido);

            //Agregar al terminator por medio de eliminadorDAL
            Eliminador terminator = new Eliminador() {
            Num_serie = num_serie,
            Tipo= tipo,
            Destino= destino,
            Objetivo = objetivo,
            Prioridad = prioridad};
            eliminadoresDAL.AgregarEliminador(terminator);
        }
        static void MostrarTerminator()
        {
            //Limpiamos y cargamos ascii a la consola
            Console.Clear();
            imprimirAscii();
            rojo("--------------MOSTRAR TERMINATOR--------------");
            Console.WriteLine();

            //Lista para obtener los terminators y luego mostrar
            List<Eliminador> eliminadores = eliminadoresDAL.ObtenerEliminadores();
            for (int i=0;i<eliminadores.Count();i++)
            {
                Eliminador actual = eliminadores[i];
                cyan(" Numero de serie:"); Console.Write(actual.Num_serie);
                cyan(" Tipo[Modelo]:"); Console.Write(actual.Tipo);
                cyan(" Objetivo:"); Console.Write(actual.Objetivo);
                cyan(" Destino:"); Console.Write(actual.Destino);
                Console.WriteLine();
                /*Console.WriteLine("Numero de serie: {0}, Tipo(Modelo): {1}, Objetivo: {2}, Destino:{3}",actual.Num_serie,actual.Tipo,
                    actual.Objetivo,actual.Destino);*/
            }
            if (eliminadores.Count==0)
            {
                Console.WriteLine();
                rojo("No se han creado Terminators");
                Console.WriteLine();
            }
            verde("                                                Pulsa enter para volver...");
            Console.ReadLine();
        }
        static void BuscarTerminator()
        {
            Console.Clear();
            imprimirAscii();
            rojo("--------------BUSCAR TERMINATOR--------------");
            Console.WriteLine();
            Console.WriteLine();
            bool esValido = false;
            //Console.WriteLine("Ingresa numero de serie y año de destino:");
            /*
            new EliminadorDAL().FiltrarEliminadores(Console.ReadLine().Trim(), Int32.Parse(Console.ReadLine().Trim())).
                ForEach(e => Console.WriteLine("Numero de serie:{1}, Tipo(Modelo):{2}, Objetivo:{3}",e.Num_serie,e.Tipo,e.Objetivo));*/

            string buscar_tipo;
            Int32 buscar_destino;
            List<Eliminador> elim = eliminadoresDAL.ObtenerEliminadores();
            if (elim.Count==0)
            {
                rojo("Aún no hay Terminators creados");
                Console.WriteLine();
                verde("                                                Pulsa enter para volver...");
                Console.ReadLine();
            }
            else
            {
                bool reiniciar = false;
                //validaciones de ingreso en tipo y destino
                do
                {
                    do
                    {
                        Console.Write("Ingresa tipo: ");
                        buscar_tipo = Console.ReadLine().Trim();
                    } while (buscar_tipo.Equals(string.Empty));
                    do
                    {
                        Console.Write("Ingresa año destino: ");
                        esValido = Int32.TryParse(Console.ReadLine().Trim(), out buscar_destino);
                    } while (!esValido);
                    List<Eliminador> eliminadores = new EliminadorDAL().FiltrarEliminadores(buscar_tipo, buscar_destino);
                    if (eliminadores.Count == 0)
                    {
                        rojo("No hay coincidencias");
                        Console.WriteLine();
                        cyan("                                                Pulsa la tecla espacio para otra búsqueda");
                        Console.WriteLine();
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        if (keyInfo.Key ==ConsoleKey.Spacebar)
                        {
                            reiniciar = true;
                        }
                        else
                        {
                            reiniciar = false;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        imprimirAscii();
                        rojo("--------------BUSCAR TERMINATOR--------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        foreach (Eliminador e in eliminadores)
                        {
                            cyan(" Numero de serie:"); Console.Write(e.Num_serie);
                            rojo("  Tipo[Modelo]:"); Console.Write(e.Tipo);
                            cyan("  Objetivo:"); Console.Write(e.Objetivo);
                            Console.WriteLine();
                            //Console.WriteLine("Numero de serie:{0}, Tipo(Modelo):{1}, Objetivo:{2}", e.Num_serie, e.Tipo, e.Objetivo);
                        }
                        verde("                                                Pulsa enter para salir...");
                        reiniciar = false;
                        Console.ReadLine();

                    }
                } while (reiniciar);
                
            }
            

        }

    }
}
