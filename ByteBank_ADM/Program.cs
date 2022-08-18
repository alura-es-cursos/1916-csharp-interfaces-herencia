// See https://aka.ms/new-console-template for more information

using ByteBank_ADM.Empleados;
using ByteBank_ADM.Directores;
using ByteBank_ADM.utils;
using ByteBank_ADM.Administrativo;
using ByteBank_ADM.Analistas;
using ByteBank_ADM.Logistica;
using ByteBank_ADM.SistemaAutenticacion;
using ByteBank_ADM.SocioComerciales;

AdminBonificacion admBonificacion = new AdminBonificacion();
SistemaAutenticacion sysAutenticacion = new SistemaAutenticacion();

Administrativo mariaRivas = new Administrativo("7384783");
//Console.WriteLine("Bonificacion administrativo: " + mariaRivas.obtenerBonificacion());
//admBonificacion.Registrar(mariaRivas);

Analista pedroPerez = new Analista("5435454");
//Console.WriteLine("Bonificacion analista: " + pedroPerez.obtenerBonificacion());
//admBonificacion.Registrar(pedroPerez);
Console.WriteLine("Autenticando a Pedro Perez");
pedroPerez.Clave = "Clave";
sysAutenticacion.loginUsuario(pedroPerez, "Clave");

Logistica juanCarrero = new Logistica("515115");
//Console.WriteLine("Autenticando a Juan Carrero");

//Console.WriteLine("Bonificacion logistica: " + juanCarrero.obtenerBonificacion());
//admBonificacion.Registrar(juanCarrero);

Director leandroBusto = new Director("989844");
Console.WriteLine("Bonificacion director: " + leandroBusto.obtenerBonificacion());
//admBonificacion.Registrar(leandroBusto);
Console.WriteLine("Autenticando a Leandro Busto");
leandroBusto.Clave = "1234";
sysAutenticacion.loginUsuario(leandroBusto, "clave");

SocioComercial luisRivas = new SocioComercial();
luisRivas.Clave = "333";
Console.WriteLine("Autenticando a Luis Rivas (Socio)");
sysAutenticacion.loginUsuario(luisRivas, "333");
//Console.WriteLine("Total bonificaciones: " +
//                    admBonificacion.obtenerTotalBonificaciones());



