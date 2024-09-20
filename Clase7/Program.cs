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

int[][] enemiesPoss = new int[5][];
Random randomAux = new Random();

for (int i = 0;i < enemiesPoss.Length; i++)
{
    // Crea un array para las coordenadas X, Y, Z.
    enemiesPoss[i] = new int[3];

    enemiesPoss[i][0] = randomAux.Next(1000); //X
    enemiesPoss[i][1] = randomAux.Next(1000); //Y
    enemiesPoss[i][2] = randomAux.Next(1000); //Z

    Console.WriteLine($"\nPosición del enemigo {i + 1}: (X, Y, Z) = ({enemiesPoss[i][0]}, {enemiesPoss[i][1]}, {enemiesPoss[i][2]})");
    enemiesPoss[i][0] += 5;
    //enemiesPoss[i][1] += 5;
    //enemiesPoss[i][2] += 5;
    Console.WriteLine($"\nPosición actualizada del enemigo {i + 1}: (X, Y, Z) = ({enemiesPoss[i][0]}, {enemiesPoss[i][1]}, {enemiesPoss[i][2]})");
}

