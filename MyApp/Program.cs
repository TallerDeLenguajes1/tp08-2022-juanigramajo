


// string[] Discos = Directory.GetLogicalDrives();
// foreach (string discoX in Discos)
// {
//     System.Console.WriteLine(discoX);
// }
// Console.ReadKey();


// List<string> ListadoDeCarpetas = Directory.GetDirectories("/Users/").ToList();
// foreach (string CarpetaY in ListadoDeCarpetas)
// {
//     System.Console.WriteLine(CarpetaY);
// }
// Console.ReadKey();


string Directorio = "/Users/juanigramajo/Desktop";
string info = Directory.GetDirectoryRoot(Directorio);
// System.Console.WriteLine("Info sobre la raíz del directorio: " + info);

// Console.ReadKey();

// List<string> ListadoDeCarpetasEnRepo = Directory.GetDirectories(Directorio).ToList();
// System.Console.WriteLine("--------------------------------------");
// System.Console.WriteLine("Carpetas en repositorio - " + Directorio);
// foreach (string Carpeta in ListadoDeCarpetasEnRepo)
// {
//     System.Console.WriteLine(Carpeta);
// }



// string macDir = System.Environment.GetEnvironmentVariable("macdir");

// FileInfo FileOp = new FileInfo(macDir + "");
// System.Console.WriteLine("File Name = " + FileOp.FullName);
// System.Console.WriteLine("Creation Time = " + FileOp.CreationTime);
// System.Console.WriteLine("Last Access Time = " + FileOp.LastAccessTime);
// System.Console.WriteLine("Last Write Time = " + FileOp.LastWriteTime);
// System.Console.WriteLine("Size = {0} Kb", ((FileOp.Length) / 2014));



if (!(Directory.Exists(Directorio + "/Tempo")))
{   
    Directory.CreateDirectory(Directorio + "/Tempo");
}

List<string> ListadoDeCarpetasEnRepo2 = Directory.GetDirectories(Directorio).ToList();
System.Console.WriteLine("--------------------------------------");
System.Console.WriteLine("Carpetas en repositorio - " + Directorio);
foreach (string Carpeta in ListadoDeCarpetasEnRepo2)
{
    System.Console.WriteLine(Carpeta);
}


string NuevoArchivo = Directorio + "/Tempo" + "/Prueba.txt";
string NuevoArchivoCopia = Directorio + "/Tempo" + "/Prueba_Copia.txt";

if (!(File.Exists(NuevoArchivo)))
{   
    File.Create(NuevoArchivo);
}

File.Move(NuevoArchivo, NuevoArchivoCopia);