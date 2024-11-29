// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int [] a = {1,2,3,4,5,6,7,8,9,10};
//for loop
for (int i=0; i<a.Length; i++)
{
    Console.WriteLine(a[i]);
}
//reverse
for (int j=0; j>=a.Length; j--)
{
    Console.WriteLine(a[j]);
}
//break keyword
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
//continue keyword
for (int i=a.Length-1; i>=0; i--)
{
    Console.WriteLine(a[i]);
}*/
/*for (int o = 0; o <101; o++)
{
    if((o % 3== 0) && (o % 5 == 0)){
        Console.WriteLine($"{o}- FizzBuzz");
    }
    else if(o % 3== 0){
        Console.WriteLine($"{o}-Fizz");
    }
    else if(o % 5 == 0){
        Console.WriteLine($"{o}-Buzz");
    }
    else{
        Console.WriteLine($" You will just have to do with{o}");
    }
}*/
/*Random number  = new Random();
int current = 0;

do{
    current = number.Next(1,100);
    Console.WriteLine(current);
}while(current != 5);
*/

/*int playerHealth = 10;
int enemyHealth = 10;

Random attack = new Random();
while(playerHealth >0 && enemyHealth >0){
    int playerAttack = attack.Next(1,10);
    int enemyAttack = attack.Next(1,10);
    playerHealth -= enemyAttack;
    enemyHealth -= playerAttack;
    Console.WriteLine($"Player Health: {playerHealth} Enemy Health: {enemyHealth}");
}
if(playerHealth <= 0){
    Console.WriteLine("You lose");
}
else{
    Console.WriteLine("You win");
}
/*int current = attack.Next(1, 11);

do{
    current = attack.Next(1, 11);
    if(current >= 8) continue;
    Console.WriteLine(current);
}
while(current != 5);*/