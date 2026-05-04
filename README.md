🔍 Verificador de Palíndromo

Este endpoint verifica se uma string informada é um palíndromo, ou seja, se pode ser lida da mesma forma de trás para frente, desconsiderando espaços e diferenças entre maiúsculas e minúsculas.

📌 Endpoint
GET /api/{controller}?input={texto}
📥 Parâmetro
input (string): Texto a ser verificado
📤 Resposta
true → quando o texto é um palíndromo
false → quando não é
🧠 Regras aplicadas
Espaços são ignorados
Letras maiúsculas e minúsculas são tratadas como iguais
✅ Exemplos
/api/palindromo?input=Arara → true
/api/palindromo?input=Ovo → true
/api/palindromo?input=Roma me tem amor → true
/api/palindromo?input=Teste → false
