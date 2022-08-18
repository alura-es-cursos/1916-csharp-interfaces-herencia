// See https://aka.ms/new-console-template for more information

using ByteBank_ADM.Empleados;
using ByteBank_ADM.Directores;
using ByteBank_ADM.utils;

AdminBonificacion admBonificacion = new AdminBonificacion();

Empleado empleado = new Empleado();
empleado.Nombre = "Leonardo José";
empleado.Dni = "8001879";
empleado.Cargo = "Desarrollador";
empleado.Salario = 10000;

admBonificacion.Registrar(empleado);

Console.WriteLine("Nombre Empleado: " + empleado.Nombre);
Console.WriteLine("Salario: " + empleado.Salario);
Console.WriteLine("Bonificacion: " + empleado.obtenerBonificacion());

Director director = new Director();
director.Nombre = "Diego Alejandro";
director.Dni = "81778815";
director.Cargo = "Director de Finanzas";
director.Salario = 100000;

admBonificacion.Registrar(director);

Console.WriteLine("Nombre Empleado: " + director.Nombre);
Console.WriteLine("Salario: " + director.Salario);
Console.WriteLine("Bonificacion: " + director.obtenerBonificacion());

Console.WriteLine("Total bonificaciones: " +
                    admBonificacion.obtenerTotalBonificaciones());
