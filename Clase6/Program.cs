//1.Subir de nivel
//Escribe un programa que permita al jugador subir de nivel. Solicita al
//jugador que ingrese la cantidad de experiencia acumulada. Si la
//experiencia es mayor a 100, el jugador sube de nivel y se resta 100
//puntos de experiencia. El proceso se repite hasta que la experiencia
//sea menor a 100. Muestra cuántos niveles subió el jugador y la
//experiencia restante.

int playerExp = 0;
int lv = 0;
int lvUp = 100;

Console.WriteLine("Ingrese la experiencia acumulada:");

playerExp = int.Parse(Console.ReadLine());

while( playerExp >= lvUp)
{

    lv++;
    playerExp -= lvUp;


    //agrego este if, que hace que cada diez niveles subidos aumente en 100
    //la experiencia necesaria para subir de nivel
    if (lv % 10 == 0) 
    {

        lvUp += 100;

    }
        
}

Console.WriteLine($"Player level: {lv} Exp: {playerExp}/{lvUp}");

//2. Solicitar Nombre del Jugador
//Escribe un programa que solicite al jugador ingresar su nombre. Si el
//nombre tiene menos de 8 caracteres, el programa debe pedir
//nuevamente el ingreso del nombre hasta que cumpla con la longitud
//requerida.





//3. Contar golpes críticos
//Escribe un programa que simule un jugador golpeando a un enemigo
//10 veces. Utiliza un bucle for para representar los golpes. En cada
//golpe, genera un número aleatorio entre 1 y 10. Si el número es 8, 9
//o 10, cuenta como un golpe crítico. Muestra cuántos golpes críticos
//realizó el jugador al final.





//4. Adivina el Número de Enemigos
//Escribe un programa en el que el jugador tenga que adivinar la
//cantidad de enemigos en una habitación. El número correcto de
//enemigos es 7. Utiliza un bucle while para permitirle al jugador intentar
//adivinar hasta que ingrese el número correcto. Después de cada
//intento, informa si el número ingresado es incorrecto y pide otro
//intento.





//5. Cargar Energía del Jugador
//Escribe un programa que simule la carga de energía de un jugador. La
//energía se carga en intervalos de 10 unidades. La energía máxima es
//100. Utiliza un bucle for para incrementar la energía del jugador en
//intervalos de 10, mostrando el progreso en cada paso. Cuando la
//energía llega a 100, el bucle debe detenerse y mostrar que la energía
//está completa.