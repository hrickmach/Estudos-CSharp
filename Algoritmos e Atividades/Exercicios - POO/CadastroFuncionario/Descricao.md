## Descrição do Exercício

Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N
funcionários. Não deve haver repetição de id.

Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário. Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma mensagem "ID INEXISTENTE" e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos.

Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente. Um salário só pode ser aumentado com base em uma porcentagem.

Veja os exemplos (os valores que devem ser digitados pelo usuário estão destacados em **negrito**):

#### Exemplo 1:

Quantos funcionários serão cadastrados? **3**



Dados do 1° funcionário:

ID: **333**

Nome: **Maria Silva**

Salario: **4000.00**



Dados do 2° funcionário:

ID: **536**

Nome: **Carlos Bastos**

Salario: **3000.00**



Dados do 3° funcionário:

ID: **772**

Nome: **Joaquim Matos**

Salario: **5000.00**



Digite o ID do funcionário que terá aumento: **536**

Digite a porcentagem de aumento: **10.0**



Listagem atualizada de funcionários:

333, Maria Silva, 4000.00

536, Carlos Bastos, 3300.00

772, Joaquim Matos, 5000.00

---

#### Exemplo 2:
Quantos funcionários serão cadastrados? **2**



Dados do 1° funcionário:

CPF: **333**

Nome: **Maria Silva**

Salario: **4000.00**



Dados do 2° funcionário:

CPF: **536**

Nome: **Carlos Bastos**

Salario: **3000.00**



Digite o CPF do funcionário que terá aumento: **222**

ID INEXISTENTE



Listagem atualizada de funcionários:

333, Maria Silva, 4000.00

536, Carlos Bastos, 3000.00
