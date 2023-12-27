using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone da marca Apple:");
Smartphone IphoneProMax = new Iphone (numero: "999888777", modelo: "Pro Max", imei: "1234", memoria: 72);
IphoneProMax.ReceberLigacao();
IphoneProMax.InstalarAplicativo("Nu Bank");

Console.WriteLine("\n");

Console.WriteLine("Smartphone da marca Nokia:");
Smartphone Nokia520 = new Nokia (numero: "666555444", modelo: "520", imei: "5678", memoria: 32);
Nokia520.Ligar();
Nokia520.InstalarAplicativo("Spotify");
