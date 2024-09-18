//1.Ataque por área
//Un código que utilice un array para almacenar los puntos de salud de
//varios enemigos. Luego, a través de bucle for se le reste un número
//fijo de salud a cada uno de los enemigos.

int[] enemiesPH = new int[5];
Random health = new Random();   

for (int i = 0; i < enemiesPH.Length; i++)
{
    enemiesPH[i] = health.Next(101);

    Console.WriteLine($"Vida del enemigo {i+1}: {enemiesPH[i]}");

    if (enemiesPH[i] > 0)
    {
        enemiesPH[i] -= 1;
        Console.WriteLine($"Vida actualizada: {enemiesPH[i]}");
    } 
    if (enemiesPH[i] == 0)
    { 
        Console.WriteLine($"Enemigo {i+1} derrotado");
    }
}


//2. Actualización de Posiciones de Enemigos
//Un código que utilice un array para almacenar las posiciones de varios
//enemigos en el juego (número entero). Luego, a través de un bucle
//for, simular la actualización la posición de cada enemigo sumándole 5
//puntos.

int[] enemiesPoss = new int[5];
Random poss = new Random();

for (int i = 0;i < enemiesPoss.Length; i++)
{
    enemiesPoss[i] = poss.Next(1000);
    Console.WriteLine($"\nPosición del enemigo: {enemiesPoss[i]}");
    enemiesPoss[i] += 5;
    Console.WriteLine($"Posición actualizada del enemigo: {enemiesPoss[i]}");
}

