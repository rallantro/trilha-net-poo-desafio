using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("112245", "Modelo 3A", "2545211111", 12);
nokia.Ligar();
nokia.InstalarAplicativo("Aplicação Modelo");

Console.WriteLine("Smartphone Nokia:");
Iphone iphone = new Iphone("0965841", "Ultra T", "1524551223", 10);
iphone.ReceberLigacao();
nokia.InstalarAplicativo("Aplicação Modelo");