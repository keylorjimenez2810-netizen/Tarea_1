using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa para calcular N aumentos salariales de una empresa....

            Console.Write("Ingrese su número de cédula: ");
            string cedula = Console.ReadLine();
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el número de empleado (1=Operario, 2=Tecnico, 3=Profesional): ");
            int tipo_empleado = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de horas trabajadas: ");
            float horas_trabajadas = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio de la hora trabajada: ");
            float precio_hora = float.Parse(Console.ReadLine());

            float salario = horas_trabajadas * precio_hora;

            float aumento = 0; 

            if (tipo_empleado == 1)
            {
                aumento = salario * 0.15f;
            }
            else if (tipo_empleado == 2)
            {
                aumento = salario * 0.10f;
            }
            else if (tipo_empleado == 3)
            {
                aumento = salario * 0.05f;
            }
            else
            {
                Console.WriteLine("Tipo de empleado no válido");
            }

            float salario_bruto = salario + aumento;
            float CCSS = salario_bruto * 0.0917f;
            float salario_neto = salario_bruto - CCSS;

            Console.WriteLine($"La cédula del empleado es: {cedula}");
            Console.WriteLine($"El nombre del empleado es: {nombre}");
            Console.WriteLine($"El tipo de empleado es: {tipo_empleado}");
            Console.WriteLine($"El salario por hora del empleado es: {precio_hora}");
            Console.WriteLine($"El número de horas trabajadas del empleado es: {horas_trabajadas}");
            Console.WriteLine($"El salario ordinario del empleado es: {salario}");
            Console.WriteLine($"El aumento del empleado es: {aumento}");
            Console.WriteLine($"El salario bruto del empleado es: {salario_bruto}");
            Console.WriteLine($"El descuento de la CCSS del empleado es: {CCSS}");
            Console.WriteLine($"El salario neto del empleado es: {salario_neto}");
        }
    }
}
