using DesafioPOO.Models;

Console.WriteLine("Testando o Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1199999999", modelo: "2022", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");
Console.WriteLine("Testando o Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "1188888888", modelo: "2024", imei: "987654321", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");