namespace Ejercicio_06_Lamparas_Switch
{
    internal class Ejercicio_06_Lamparas_Switch
    {
     // Una empresa que se dedica a la comercialización de lámparas de bajo consumo, registra de sus ventas, los siguientes datos: marca y cantidad.El precio de cada lamparita es de $150 (Sin importar la marca).
     // El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.
     // A.Si compra 6 lamparitas o más, tiene un descuento del 50%.
     // B.Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40% y si es de otra marca, el descuento es del 30%.
     // C.Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25%, y si es de otra marca el descuento es del 20%.
     // D.Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15%, si es “FelipeLamparas se hace un descuento del 10% y si es otra marca, 5%.
     // E.Si el importe final con descuento suma más de $950, se debe agregar el 10% de ingresos brutos.
     // Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento, y si corresponde total de ingresos brutos y total a pagar.

        static void Main(string[] args)
        {

            double precioLamparita;
            precioLamparita = 150;
            string marcaLamparita;
            int cantidadDeLamparitas;
            double totalSinDescuento;
            double descuento;
            double porcentajeDescuento;
            double TotalAPagar;
            double ingresosBrutos;


            Console.WriteLine("Bienvenido al sistema de compras de lamparitas!");
            Console.WriteLine("Por favor seleccione la cantidad que desea comprar");
            cantidadDeLamparitas = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor seleccione la marca que desee");
            marcaLamparita = Console.ReadLine();

            switch (cantidadDeLamparitas)
            {
                case >= 6:
                    {
                        porcentajeDescuento = 0.50;
                        break;

                    }
                case 5:

                    {
                        if (marcaLamparita == "ArgentinaLuz")
                        {
                            porcentajeDescuento = 0.40;
                        }
                        else
                        {
                            porcentajeDescuento = 0.30;

                        }
                        break;
                    }

                case 4:

                    {
                        if (marcaLamparita == "ArgentinaLuz" || marcaLamparita == "FelipeLamparas")
                        {
                            porcentajeDescuento = 0.25;

                        }
                        else
                        {
                            porcentajeDescuento = 0.20;
                        }
                    }
                    break;

                case 3:
                    {
                        if (marcaLamparita == "ArgentinaLuz")
                        {
                            porcentajeDescuento = 0.15;
                        }
                        else
                        {
                            if (marcaLamparita == "FelipeLampara")
                            {
                                porcentajeDescuento = 0.10;
                            }
                            else
                            {
                                porcentajeDescuento = 0.05;
                            }
                        }
                    } 
                    break;

                default:
                    {
                        porcentajeDescuento = 0;
                    }
                    break;

            }

            Console.WriteLine("Perfecto, Aqui el registro de su compra!");

            Console.WriteLine($"Usted ordeno {cantidadDeLamparitas} lamparitas de marca {marcaLamparita}");
            totalSinDescuento = cantidadDeLamparitas * precioLamparita;
            Console.WriteLine($"El precio total sin descuentos es de: $ {totalSinDescuento}");

            Console.WriteLine($"El total a pagar es: {totalSinDescuento}");
            descuento = porcentajeDescuento * totalSinDescuento;
            if( descuento > 0 )
            {
                Console.WriteLine($"Felicitaciones por su compra tiene un descuento de $ {descuento}");
            }
            TotalAPagar = totalSinDescuento - descuento;
            if (TotalAPagar > 950)
            {
                ingresosBrutos = TotalAPagar * 0.10;
                TotalAPagar = TotalAPagar + ingresosBrutos;
                
                Console.WriteLine($"Como su compra supera los $ 950, tiene que pagar ingresos brutos que son : $ {ingresosBrutos} mas");
            }
            Console.WriteLine($"El total a pagar es de: $ {TotalAPagar}");
            }
        }
    }
