//ACTIVIDAD DE AUTOEVALUACION DE REPASO DE LA UNIDAD 1


// Borrar "//" al principio de las líneas de código del bloque correspondiente al ejercicio a ejecutar.


//1) Un sistema que solicite el ingreso del nombre del personaje. Luego,
//el sistema debe mostrar la inicial del nombre ingresado. Por lo tanto,
//si se ingresa el nombre “Juan” el sistema debe mostrar la letra “J”.


//Console.WriteLine("Ingresa tu nombre: ");
//string namePJ = Console.ReadLine();
//Console.WriteLine(namePJ[0]);


//2) Un sistema que solicite el ingreso de 3 números enteros. Esos 3
//números enteros deben ser enviados a una función que los sume, y
//muestre en pantalla el resultado de la suma.


//int suma(int x, int y, int z)
//{
//    return x + y + z;  
//}

//Console.WriteLine("Ingresa un numero: ");
//int numA = int.Parse(Console.ReadLine());

//Console.WriteLine("Ingresa otro numero: ");
//int numB = int.Parse(Console.ReadLine());

//Console.WriteLine("Ingresa un numero mas: ");
//int numC = int.Parse(Console.ReadLine());

//Console.WriteLine(suma(numA, numB, numC));


//3) Un sistema que solicite el ingreso de la edad del personaje. Luego, el
//sistema debe mostrar la edad ingresada multiplicada por 2.


//Console.WriteLine("Ingresa la edad: ");
//int edadPJ = int.Parse(Console.ReadLine());

//Console.WriteLine($"La edad duplicada es {edadPJ * 2}");


//4) Un sistema que solicite el ingreso del nombre del juego. Luego, el
//sistema debe mostrar el nombre en mayúsculas.


//Console.WriteLine("Ingresa el nombre del juego: ");
//string gameName = Console.ReadLine().ToUpper();

//Console.WriteLine(gameName);


//5) Un sistema que solicite el ingreso de dos números enteros. Esos dos
//números deben ser enviados a una función que calcule el producto y
//muestre en pantalla el resultado.


//int producto(int x, int y)
//{
//    return x * y;  
//}

//Console.WriteLine("Ingresa un numero: ");
//int numA = int.Parse(Console.ReadLine());

//Console.WriteLine("Ingresa otro numero: ");
//int numB = int.Parse(Console.ReadLine());

//Console.WriteLine(producto(numA, numB));


//6) Un sistema que solicite el ingreso del puntaje de tres niveles del
//juego. Luego, el sistema debe mostrar el puntaje total sumando los
//tres valores ingresados.


//Console.WriteLine("Puntaje LV 1: ");
//int numA = int.Parse(Console.ReadLine());

//Console.WriteLine("Puntaje LV 2: ");
//int numB = int.Parse(Console.ReadLine());

//Console.WriteLine("Puntaje LV 3: ");
//int numC = int.Parse(Console.ReadLine());

//Console.WriteLine(numA + numB + numC);


//7) Un sistema que solicite el ingreso de la cantidad de enemigos
//derrotados. Luego, el sistema debe mostrar el puntaje obtenido,
//sabiendo que cada enemigo derrotado otorga 10 puntos.


//Console.WriteLine("Enemigos derrotados: ");
//int contDerrotados = int.Parse(Console.ReadLine());

//Console.WriteLine($"Puntaje: {contDerrotados * 10}");


//8) Un sistema que solicite el ingreso del nombre del personaje y su salud
//actual. Luego, el sistema debe mostrar la salud como porcentaje de
//la salud máxima que es de 100.

//int maxHP = 100;

//Console.WriteLine("Ingresa tu nombre: ");
//string namePJ = Console.ReadLine();

//Console.WriteLine("Ingresa tu HP actual: ");
//int charHP = int.Parse(Console.ReadLine());

//int aux1 = maxHP - charHP;

//Console.WriteLine(new string('■', charHP) + new string('_', aux1));


//9) Un sistema que solicite el ingreso de la cantidad de enemigos
//derrotados por un jugador en tres niveles distintos. Luego, el sistema
//debe calcular y mostrar el promedio de enemigos derrotados por
//nivel.


//Console.WriteLine("Derrotados LV 1: ");
//int numA = int.Parse(Console.ReadLine());

//Console.WriteLine("Derrotados LV 2: ");
//int numB = int.Parse(Console.ReadLine());

//Console.WriteLine("Derrotados LV 3: ");
//int numC = int.Parse(Console.ReadLine());

//float promedioDerrotados = (numA + numB + numC) / 3.0f;

//Console.WriteLine(Math.Round(promedioDerrotados, 2).ToString("F2"));


//10) Un sistema que solicite el ingreso del nombre de un jugador y la
//cantidad de puntos obtenidos en cinco partidas diferentes. Luego, el
//sistema debe mostrar el nombre del jugador y el puntaje total
//obtenido.


//Console.WriteLine("Ingresa tu nombre: ");
//string namePJ = Console.ReadLine();

//Console.Write("Ingrese los puntos obtenidos en la partida 1: ");
//int puntos = int.Parse(Console.ReadLine());

//Console.Write("Ingrese los puntos obtenidos en la partida 2: ");
//puntos += int.Parse(Console.ReadLine());

//Console.Write("Ingrese los puntos obtenidos en la partida 3: ");
//puntos += int.Parse(Console.ReadLine());

//Console.Write("Ingrese los puntos obtenidos en la partida 4: ");
//puntos += int.Parse(Console.ReadLine());

//Console.Write("Ingrese los puntos obtenidos en la partida 5: ");
//puntos += int.Parse(Console.ReadLine());

//Console.WriteLine($"Nombre del jugador: {namePJ}");
//Console.WriteLine($"Puntaje total obtenido: {puntos}");


//11) Un sistema que solicite el ingreso del nombre del juego y el tiempo
//jugado en minutos. Luego, el sistema debe convertir y mostrar el
//tiempo jugado en horas y minutos.


//Console.WriteLine("Ingresa el nombre del juego: ");
//string game = Console.ReadLine();

//Console.Write("Ingrese los minutos jugados: ");
//int timePlayed = int.Parse(Console.ReadLine());

//int hours = timePlayed / 60;
//int minutes = timePlayed % 60;

//Console.WriteLine($"Has jugado {game} durante {hours} horas y {minutes} minutos.");


//12) Un sistema que solicite el ingreso de los nombres de tres personajes.
//Luego, el sistema debe mostrar los nombres en orden inverso al
//ingreso.


//string[] namePJ = new string[3];

//Console.WriteLine("Nombre personaje 1: ");
//namePJ[0] = Console.ReadLine();

//Console.WriteLine("Nombre personaje 2: ");
//namePJ[1] = Console.ReadLine();

//Console.WriteLine("Nombre personaje 3: ");
//namePJ[2] = Console.ReadLine();

//Console.WriteLine($"Personaje 3: {namePJ[2]} \nPersonaje 2: {namePJ[1]} \nPersonaje 1: {namePJ[0]}");


//13) Un sistema que solicite la cantidad de enemigos comunes derrotados,
//y la cantidad de enemigos de tipo Boss. Luego debe devolver el
//puntaje total, sabiendo que los enemigos comunes suman 10 puntos
//y los bosses 50 puntos.


//int pointsCommon = 10;
//int pointsBoss = 50;

//Console.WriteLine("Enemigos comunes derrotados: ");
//int enemyCommon = int.Parse(Console.ReadLine());

//Console.WriteLine("Jefes derrotados: ");
//int enemyBoss = int.Parse(Console.ReadLine());

//int totalPoints = enemyBoss * pointsBoss + enemyCommon * pointsCommon;

//Console.WriteLine($"Puntos totales: {totalPoints}");
