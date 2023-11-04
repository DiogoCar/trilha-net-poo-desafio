using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone Nokia = new Nokia (numero: "55555", modelo: "Modelo A",imei: "111", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Bloco de Notas");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone= new Nokia (numero: "77777", modelo: "Modelo 6",imei: "777", memoria: 128);
Iphone.Ligar();
Iphone.InstalarAplicativo("Instagram");
