using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smarphone Motorola");

Smartphone nokia = new Nokia(numero: "984160795", modelo: "Motoe",iMEI:"358147", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Iphone iphone = new Iphone(numero:"984827646",modelo:"Iphone 7",iMEI: "111111",memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");