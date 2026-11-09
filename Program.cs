using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_F
{
    internal class Program
    {
        static string[] codigos = { "Auto-201", "Auto-202", "Auto-203", "Auto-204", "Auto-205", "Auto-206" };
        static string[] modelos = { "SUV interceptor", "Sedan Executive", "PickUp Titan", "City Hatchback", "Electric EV", "Van carga" };
        static double[,] matrizVentadeDatos = { { 28000.0, 2 }, { 185000.0, 4 }, { 35000.0, 1 }, { 14000.0, 5 }, { 42000.0, 1 }, { 22500.0, 3 } };

        public static bool ValidarDatos(double precio, int cantidad)
        {
            if (precio > 0 && cantidad > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error, el precio y la cantidad deben ser mayor a 0");
                return false;
            }
        }
        public static double MontoNetoPorVenta(double precio, int cantidad)
        {
            Console.WriteLine("Monto neto por venta");
            double montoNeto = precio * cantidad;
            return montoNeto;
        }
        public static void TotalAcumulado(double montoNeto)
        {
            Console.WriteLine("Total acumulado de ventas");
            double TotalAcumulado = 0;
            TotalAcumulado = TotalAcumulado + montoNeto;
        }
        public static void VentasPremium(double MontoNeto)
        {
            double contadorVentasPremium = 0;
            Console.WriteLine("Ventas premium");
            if (MontoNeto > 5000000)
            {
                contadorVentasPremium++;
                Console.WriteLine("Cantidad de ventas premium: " + contadorVentasPremium);
            }
        }
        public static void ImprimirMatrizDatos(double[,] matriz, string[] codigos)
        {
            Console.WriteLine("----MATRIZ BIDIMENSIONAL DE DATOS(PRECIO Y CANTIDAD----");
            Console.WriteLine("FILA | CODIGO | COL 0(PRECIO) | COL 1(CANTIDAD) ");
            Console.WriteLine("-----------------------------------------------------");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Codigo: " + codigos[i] + "|" + " Precio: " + matriz[i, 0] + "|" + " Cantidad: " + matriz[i, 1] + "|");
            }
        }
        public static void DescendenteBurbuja()
        {

        }
        public static void BuscarCodigo(string[] codigos, string[] modelos, double[] precio, string codigoBuscado)
        {
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == codigoBuscado)
                {
                    Console.WriteLine("Codigo: " + codigos[i] + " Modelo: " + modelos[i] + " Precio: " + precio[i]);
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("\tCONTROL DE VENTAS AUTOMOTRICES(EVALUACION 45 MIN)");
            Console.WriteLine("===============================================================");
            ImprimirMatrizDatos(matrizVentadeDatos, codigos);
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
