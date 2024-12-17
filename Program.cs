using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Snartphone Nokia:");
Smartphone nokia = new Nokia(numero: "4692123456", modelo: "12354", imei: "856", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Snartphone Iphone:");
Smartphone iphone = new Iphone(numero: "7777777", modelo: "3256", imei: "857", memoria: 12);
iphone.Ligar();
iphone.InstalarAplicativo("Uber");
