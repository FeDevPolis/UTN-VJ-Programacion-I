//1.Vida del jugador
//Escribe un programa que te solicite el ingreso por consola de la vida
//del jugador. Si la vida es de 0 o menos, debe imprimirse un mensaje
//de derrota. Si la vida es superior a 0, debe imprimirse que el jugador
//está vivo.


Console.WriteLine("Ingresa la vida del jugador");
int life = int.Parse(Console.ReadLine());

if (life <= 0)
{
    Console.WriteLine("Has sido derrotado");
}
else 
{
    Console.WriteLine("El jugador esta vivo");
}


//2. Arma del jugador
//Desarrolla un programa donde el jugador pueda ingresar por consola
//un arma. Elige entre las siguientes armas: "Espada", "Arco" y "Magia".
//Utiliza una estructura switch para mostrar un mensaje dependiendo
//del arma seleccionada, indicando las características y habilidades
//especiales de cada una.

Console.WriteLine("\nElige tu arma: \n1. Espada\n2. Arco\n3. Magia");
string choice = Console.ReadLine().Replace(" ","");

switch (choice)
{
    case "1":
        Console.WriteLine("Espada seleccionada! \nDPS: 150");
        break;
    case "2":
        Console.WriteLine("Arco seleccionado! \nDPS: 90");
        break;
    case "3":
        Console.WriteLine("Magia seleccionado! \nDPS: 180\nMana: 40");
        break;
    default:
        Console.WriteLine("Opcion incorrecta");
        break;
}


//EJERCICIOS EXTRA

//1.Nivel del jugador
//Escribe un programa que solicite el nivel del jugador. Si el nivel es
//menor a 5, muestra "Novato". Si el nivel está entre 5 y 10, muestra
//"Intermedio". Si es mayor a 10, muestra "Experto".
int level;

Console.WriteLine("\nIngresa tu nivel: ");
level = int.Parse(Console.ReadLine());

if (level < 5)
{    
    Console.WriteLine("Novato");
}
else if (level > 10)
{
    Console.WriteLine("Experto");
}
else
{
    Console.WriteLine("Intermedio");
}

//2. Monedas del jugador
//Escribe un programa que reciba la cantidad de monedas que tiene el
//jugador. Si tiene más de 100 monedas, muestra "Puedes comprar una
//mejora". Si tiene exactamente 100 monedas, muestra "Puedes
//comprar un arma". Si tiene menos de 100, muestra "Necesitas más
//monedas".

int coins = 0;

Console.WriteLine("\nIngrese las monedas acumuladas:");
coins = int.Parse(Console.ReadLine());

if (coins > 100)
{
    Console.WriteLine("Puedes comprar una mejora");
} else if (coins == 100)
{
    Console.WriteLine("Puedes comprar un arma");
}
else
{
    Console.WriteLine("Necesitas más monedas");
}

//3. Personaje del jugador
//Desarrolla un programa que permita al jugador elegir entre tres
//personajes: "Guerrero", "Mago" y "Arquero". Utiliza un switch para
//mostrar en consola estadísticas dependiendo el personaje
//seleccionado. En caso de que se ingrese un nombre distinto a los
//solicitados, debe decir que el personaje es inválido.
//Tip: Utiliza.ToLower o .ToUpper para evitar problemas con mayúsculas
//o minúsculas.

Console.WriteLine("\nElija un personaje: \n1- Guerrero\n2- Mago\n3- Arquero");
choice = Console.ReadLine().Replace(" ","").ToLower();

string result = choice switch
{
    "1" or "guerrero"=> "Agilidad: 30 \nFuerza: 50 \nInteligencia: 10",
    "2" or "mago"=> "Agilidad: 20 \nFuerza: 20 \nInteligencia: 50",
    "3" or "arquero"=> "Agilidad: 50 \nFuerza: 30 \nInteligencia: 10",
    _ => "Opcion incorrecta"
};

Console.WriteLine(result);

//switch (choice)
//{
//    case "1" or "guerrero": 
//        Console.WriteLine("\nAgilidad: 30 \nFuerza: 50 \nInteligencia: 10");
//        break;

//    case "2" or "mago":
//        Console.WriteLine("\nAgilidad: 20 \nFuerza: 20 \nInteligencia: 50");
//        break;

//    case "3" or "arquero":
//        Console.WriteLine("\nAgilidad: 50 \nFuerza: 30 \nInteligencia: 10");
//        break;

//    default:
//        Console.WriteLine("Opcion incorrecta");
//        break;
//}


//4. Sistema de Combate
//Escribe un programa que simule un sistema de combate. Solicita al
//jugador su nivel, fuerza y agilidad. Tené en cuenta que:
//• El daño base del jugador es 10.
//• Si el nivel es mayor a 10 y la fuerza es mayor a 15, el daño se
//duplica.
//• Si la agilidad es mayor a 20, se añade un 50% al daño. Muestra
//el daño final.
//• El efecto de los dos bonus pueden darse en simultáneo.

int damage = 10;

Console.WriteLine("\nIngresa tu nivel: ");
level = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu fuerza: ");
int force = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu agilidad: ");
int agility = int.Parse(Console.ReadLine());

if (level > 10 && force > 15)
{
    if (agility > 20)
    {
        Console.WriteLine($"Daño: {damage * 2 + damage * 1.5}");
    }
    else
    {
        Console.WriteLine($"Daño: {damage * 2}");
    }
}
else if (agility > 20)
{
    Console.WriteLine($"Daño: {damage * 1.5}");
}
else
{
    Console.WriteLine($"Daño: {damage}");
}


//5. Sistema de Puntuación con Bonus
//Escribe un programa que calcule la puntuación del jugador. Solicita el
//tiempo (en minutos) que el jugador tardó en completar un nivel, y la
//cantidad de enemigos derrotados. Si el tiempo es menor a 5 minutos
//y se derrotaron más de 10 enemigos, aplica un bonus de 100 puntos.
//Si el tiempo es mayor a 10 minutos o menos de 5 enemigos fueron
//derrotados, aplica una penalización de 50 puntos. Muestra la
//puntuación total.

int time;
int enemies;
int bonus = 0;

Console.WriteLine("\nCuántos minutos tardó en completar el nivel?");
time = int.Parse(Console.ReadLine());

Console.WriteLine("Cuántos enemigos derrotó?");
enemies = int.Parse(Console.ReadLine());

if (time < 5 && enemies > 10)
{
    bonus = 100;
}else if (time > 10 || enemies < 5)
{
    bonus = -50;
}

Console.WriteLine($"Enemigos derrotados: {enemies} x 10 pts\nBonus:  {bonus} pts\nTotal: {enemies * 10 + bonus} pts");


//6. Escudo y Defensa del Jugador
//Escribe un programa que determine el estado de defensa del jugador.
//Solicita la resistencia del escudo y la agilidad del jugador. Si la
//resistencia del escudo es mayor a 50 o la agilidad es mayor a 30,
//muestra "Defensa Alta". Si la resistencia del escudo es menor a 20 y
//la agilidad es menor a 15, muestra "Defensa Baja". Si no se cumplen
//ninguna de estas condiciones, muestra "Defensa Media".


Console.WriteLine("\nIngresa la resistencia de tu escudo: ");
int shield = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu agilidad: ");
agility = int.Parse(Console.ReadLine());

if (shield > 50 || agility > 30)
{
    Console.WriteLine("Defensa ALTA");
}
else if (shield < 20 && agility < 15)
{
    Console.WriteLine("Defensa BAJA");
}
else
{
    Console.WriteLine("Defensa MEDIA");
}

