//1.Vida del jugador
//Escribe un programa que te solicite el ingreso por consola de la vida
//del jugador. Si la vida es de 0 o menos, debe imprimirse un mensaje
//de derrota. Si la vida es superior a 0, debe imprimirse que el jugador
//está vivo.


Console.WriteLine("Ingresa la vida del jugador");
int vida = int.Parse(Console.ReadLine());

if (vida <= 0)
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
int seleccion = int.Parse(Console.ReadLine());

switch (seleccion)
{
    case 1:
        Console.WriteLine("Espada seleccionada! \nHP: 150\nFuerza: 100\nAgilidad: 75\nInteligencia: 50");
        break;
    case 2:
        Console.WriteLine("Arco seleccionado! \nHP: 90\nFuerza: 75\nAgilidad: 100\nInteligencia: 50");
        break;
    case 3:
        Console.WriteLine("Magia seleccionado! \nHP: 100\nFuerza: 50\nAgilidad: 50\nInteligencia: 100");
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
else if (level < 10)
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



//3. Personaje del jugador
//Desarrolla un programa que permita al jugador elegir entre tres
//personajes: "Guerrero", "Mago" y "Arquero". Utiliza un switch para
//mostrar en consola estadísticas dependiendo el personaje
//seleccionado. En caso de que se ingrese un nombre distinto a los
//solicitados, debe decir que el personaje es inválido.
//Tip: Utiliza.ToLower o .ToUpper para evitar problemas con mayúsculas
//o minúsculas.



//4. Sistema de Combate
//Escribe un programa que simule un sistema de combate. Solicita al
//jugador su nivel, fuerza y agilidad. Tené en cuenta que:
//• El daño base del jugador es 10.
//• Si el nivel es mayor a 10 y la fuerza es mayor a 15, el daño se
//duplica.
//• Si la agilidad es mayor a 20, se añade un 50% al daño. Muestra
//el daño final.
//• El efecto de los dos bonus pueden darse en simultáneo.



//5. Sistema de Puntuación con Bonus
//Escribe un programa que calcule la puntuación del jugador. Solicita el
//tiempo (en minutos) que el jugador tardó en completar un nivel, y la
//cantidad de enemigos derrotados. Si el tiempo es menor a 5 minutos
//y se derrotaron más de 10 enemigos, aplica un bonus de 100 puntos.
//Si el tiempo es mayor a 10 minutos o menos de 5 enemigos fueron
//derrotados, aplica una penalización de 50 puntos. Muestra la
//puntuación total.



//6. Escudo y Defensa del Jugador
//Escribe un programa que determine el estado de defensa del jugador.
//Solicita la resistencia del escudo y la agilidad del jugador. Si la
//resistencia del escudo es mayor a 50 o la agilidad es mayor a 30,
//muestra "Defensa Alta". Si la resistencia del escudo es menor a 20 y
//la agilidad es menor a 15, muestra "Defensa Baja". Si no se cumplen
//ninguna de estas condiciones, muestra "Defensa Media".
