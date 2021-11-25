## Descri��o do Projeto
De maneira bem resumida o Delegate funciona como uma forma de abstrair ou delegar uma fun��o
para que ela receba par�metros n�o necess�riamente sabe o que fazer, pois quem vai tratar a informa��o � a fun��o a qual foi atribuida a ele.

Temos ent�o no exemplo um conte�do onde o Delegate � apenas o Calcular que recebe 2 valores e retorna um inteiro, conforme a classe Form1.cs
nela � poss�vel identificar que ao instanciamos o Delegate passamos a fun��o especifica que ele receber�, a fun��o tamb�m espera 2 par�metros iguais ao Delegate (s�o do mesmo tipo)
quando ent�o chamado � passado os valores e temos ent�o os resultados esperados de acordo com as configura��es.


------------------------------------
Outro ponto importante � que o Delegate pode apontar mais de uma chamada de m�todo veja no exemplo do bot�o MULTICAST 
(Atente-se que se um Delegate retornar um valor, o �ltimo valor do m�todo de destino atribu�do ser� retornado quando for um multcast)
-------------------------------------