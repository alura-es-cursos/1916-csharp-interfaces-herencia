// See https://aka.ms/new-console-template for more information

using ByteBank_ADM.Empleados;
using ByteBank_ADM.Directores;
using ByteBank_ADM.utils;
using ByteBank_ADM.Administrativo;
using ByteBank_ADM.Analista;
using ByteBank_ADM.Logistica;

AdminBonificacion admBonificacion = new AdminBonificacion();

Administrativo mariaRivas = new Administrativo("7384783");
Console.WriteLine("Bonificacion administrativo: " + mariaRivas.obtenerBonificacion());
admBonificacion.Registrar(mariaRivas);

Analista pedroPerez = new Analista("5435454");
Console.WriteLine("Bonificacion analista: " + pedroPerez.obtenerBonificacion());
admBonificacion.Registrar(pedroPerez);

Logistica juanCarrero = new Logistica("515115");
Console.WriteLine("Bonificacion logistica: " + juanCarrero.obtenerBonificacion());
admBonificacion.Registrar(juanCarrero);

Director leandroBusto = new Director("989844");
Console.WriteLine("Bonificacion director: " + leandroBusto.obtenerBonificacion());
admBonificacion.Registrar(leandroBusto);


Console.WriteLine("Total bonificaciones: " +
                    admBonificacion.obtenerTotalBonificaciones());



