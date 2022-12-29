using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smarphone Nokia");

Smartphone nokia = new Nokia(numero: "984160795", modelo: "Motoe",iMEI:"358147", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Iphone iphone = new Iphone(numero:"984827646",modelo:"Iphone 7",iMEI: "111111",memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");