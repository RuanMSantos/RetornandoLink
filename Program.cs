using System.Text;

string linkHex = "68747470733A2F2F796F7574752E62652F47684E33697730594C57513F73693D6A4749566C506834347750594E496748";

// O array vai ter a metade da quantidade de caracteres do link, pois um byte
// retorna dois caracteres em hexadecimal, então na verdade a quantide de
// caracteres está duplicada.
byte[] arrayByte = new byte[linkHex.Length / 2];

for (int i = 0; i < arrayByte.Length; i++){
    arrayByte[i] = Convert.ToByte(linkHex.Substring(i * 2, 2), 16);
    // Cada posição vai guardar: pega sempre dois caracteres da string, relativamente
    // E na função de conversão para byte, são passados dois parametros, os caracteres
    // em string, e sua base numérica, que nesse caso é 16 = hexadecimal.
    // é extremamente importante passar a base numérica, pois ela quem possibilita
    // identificar que aqueles caracteres são hex. Se fosse substituiddo por 10,
    // poderia dar erro, caso os caracteres não representem um valor decimal. 
}

string link = Encoding.UTF8.GetString(arrayByte);
// transforma o código em uma string normal, passamos o tipo de escrita e o tipo de
// dado que queremos. 

Console.WriteLine(link);