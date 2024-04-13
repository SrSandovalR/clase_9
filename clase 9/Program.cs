using clase_9.ClaseHijo;

Nintendo nintendo = new Nintendo();
nintendo.aniolanzamiento = 2017;
nintendo.esPortable=true;
nintendo.marca = "switch";
Console.WriteLine(nintendo.MostrardetallesNintendo());

//instancia de ps1

Playstation ps = new Playstation();
ps.marca = "playstation 1";
ps.aniolanzamiento = 1994;
ps.modelocontrolador = "dualsense";
Console.WriteLine($"{ps.mostrardetallesplay}");


xbox xbox = new xbox();

xbox.escuadrada = "escuadrada";
Console.WriteLine(xbox.mostrardetallesXbox());



segadreamcast sega = new segadreamcast();

sega.aniodesalida = "Es muy vieja";
Console.WriteLine (sega.mostrardetallessega());

