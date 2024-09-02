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

Console.WriteLine("Elige tu arma: \n1. Espada\n2. Arco\n3. Magia");
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