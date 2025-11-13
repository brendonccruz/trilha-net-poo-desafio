using DesafioPOO.Models;

Nokia n1 = new Nokia(numero: "27 99999-9999", modelo: "Nokia Lumia", imei: "12345-6", memoria: 64);

Console.WriteLine("Nokia");
Console.WriteLine();
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Iphone i1 = new Iphone(numero: "27 99999-9999", modelo: "iPhone 15", imei: "78912-3", memoria: 128);

Console.WriteLine("iPhone");
Console.WriteLine();
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");