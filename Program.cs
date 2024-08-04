using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "55874", modelo: "11", imei: "258744", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Iphone(numero: "12547", modelo: "4", imei: "887455", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tiktok");