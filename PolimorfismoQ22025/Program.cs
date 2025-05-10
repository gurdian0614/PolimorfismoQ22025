
using PolimorfismoQ22025;

Casa casa = new Casa(48, 500000);
casa.Ubicacion = "Tegucigalpa";
casa.Vender();
casa.Vender("Roger Gurdian");

Console.WriteLine();

Departamento departamento = new Departamento();
departamento.Ubicacion = "Choluteca";
departamento.Vender();
departamento.Ubicacion = "Lepaterique";
departamento.Vender("Juan Perez");
departamento.Vender("Choloma", 50, 1500000);

Console.WriteLine();

Terreno terreno = new Terreno();
terreno.Vender();