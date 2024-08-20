/*
Consigna 1.
Monedas de Oro, Plata y Bronce
Realice un sistema que permita ingresar la cantidad de monedas de
oro, plata y bronce que tiene el jugador. Luego, debe mostrar en
consola cuántas monedas tiene en total y cuál es el valor total,
sabiendo que las monedas de oro tienen un valor de 5, las de plata
valen 3, y las de bronce 1.
*/

// se pide input al usuario de la cantidad de monedas de cada tipo
// y se transforma de string a int almacenandolo en una variable
Console.WriteLine("Ingrese la cantidad de monedas de oro que posee: ");
int monedasOro = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de monedas de plata que posee: ");
int monedasPlata = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de monedas de bronce que posee: ");
int monedasBronce = int.Parse(Console.ReadLine());

// se declaran variables para los valores de cada tipo de moneda oro-plata-bronce
int valorOro = 5;
int valorPlata = 3;
int valorBronce = 1;

// se suma el total de monedas
int totalMonedas = monedasBronce + monedasPlata + monedasOro;

// se calcula el puntaje acumulado sumando la cantidad de monedas de cada tipo multiplicadas por su valor
int puntajeSumatoria = monedasOro * valorOro + monedasPlata * valorPlata + monedasBronce * valorBronce;

Console.WriteLine("Total de monedas: " + totalMonedas + "\nValor total: " + puntajeSumatoria);

/*
Consigna 2. 
Registro de Jugadores
Realice un sistema que solicite al jugador que ingrese su nombre, nivel
y clase de personaje. Luego, muestra un mensaje de bienvenida
personalizado y su información de personaje.
*/

// se define una variable name para registrar el nombre del jugador
Console.WriteLine("\n\nUsted está ingresando en los dominios de Tierras Lejanas. Por favor ingrese su Nombre: ");
string name = Console.ReadLine();

// se define una variable level para registrar el nivel del jugador
Console.WriteLine("\nQue nivel eres? ");
int level = int.Parse(Console.ReadLine());

// se define una variable characterClass para registrar la clase del jugador 
Console.WriteLine("\nQue clase eres? ");
string characterClass = Console.ReadLine();

Console.WriteLine("\n\n¡¡¡Bienvenido a Tierras Lejanas " + name + " (lv " + level + ") " + characterClass + " !!!");

/*
Consigna 3. 
Poder de ataque
Realice un sistema que solicite el nivel del personaje y el daño del
arma. Debe calcular el poder de ataque total y mostrarlo en consola.
El poder de ataque surgirá de multiplicar ambos valores ingresados.
*/

// se utiliza la misma variable level declarada en la consigna anterior Línea 48
Console.WriteLine("\n\nIngrese su nivel: ");
level = int.Parse(Console.ReadLine());

// se define la variable damageWeapon para el dañoo del arma
Console.WriteLine("\nIngrese el daño de su arma: ");
int damageWeapon = int.Parse(Console.ReadLine());

// se define el daño total multiplicando damageWeapon por level y se almacena en la variable powerDPS 
int powerDPS = level * damageWeapon;

Console.WriteLine("\n\nSu daño total es " + powerDPS + " de daño");
