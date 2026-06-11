// Escreva a mensagem "informe um numero: '
Console.Write("Informe um numero: ");
//Cria a variavel que salva o numero , Leia o que o usuario digitar e transforma o valor lido de texto para inteiro (int.Parse)
//leia o que o usuário digitar
// e transforma o valor lido de texto para inteiro (int.Parse)
int variavelQueSalvaUmNumero = int.Parse(Console.ReadLine()!) ;

// verifica se o valor de variavelQueSalvaUmNumero é par
if (variavelQueSalvaUmNumero % 2 ==0) {   
    Console.WriteLine($"número {variavelQueSalvaUmNumero} é par");

} else { 
    Console.WriteLine($"número {variavelQueSalvaUmNumero} é impar");
}


