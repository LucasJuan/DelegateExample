## Descrição do Projeto
De maneira bem resumida o Delegate funciona como uma forma de abstrair ou delegar uma função
para que ela receba parâmetros não necessáriamente sabe o que fazer, pois quem vai tratar a informação é a função a qual foi atribuida a ele.

Temos então no exemplo um conteúdo onde o Delegate é apenas o Calcular que recebe 2 valores e retorna um inteiro, conforme a classe Form1.cs
nela é possível identificar que ao instanciamos o Delegate passamos a função especifica que ele receberá, a função também espera 2 parâmetros iguais ao Delegate (são do mesmo tipo)
quando então chamado é passado os valores e temos então os resultados esperados de acordo com as configurações.


------------------------------------
Outro ponto importante é que o Delegate pode apontar mais de uma chamada de método veja no exemplo do botão MULTICAST 
(Atente-se que se um Delegate retornar um valor, o último valor do método de destino atribuído será retornado quando for um multcast)
-------------------------------------