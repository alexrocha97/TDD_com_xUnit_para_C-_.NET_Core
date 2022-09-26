# Repositorio do curso de TDD com xUnit para C# .NET Core


## Escopo da aplicação:
### Entidades:
<br>Curso
<br>Deverá ter os campos nome,carga horária, público alvo e valor
<br> Não deverá repetir o nome do curso
<br>
<br>Aluno
<br>Campos: nome, CPF, data de nascimento, seu público alvo
<br>Não deve permitir salvar dois CPFs iguais
<br>
<br>Matricula
<br>Campos: curso, aluno, valor pago
<br>Aluno não deve afetuar uma matricula, caso a primeira esteja aberta
<br>Alguns aluno não pagam o valor do curso cheio, nesse caso é dado um desconto. Porém o nunca aluno deverá pagar mais do que o valor do curso
<br>No momento da matricula, o público alvo do curso e aluno devem ser o mesmo


### TDD (Test Driven Development) - Desenvolvimento Orientado por Testes 
<p>
É uma abordagem para escrever os testes antes mesmo de desenvolver o código do software</p>
<h2> Benefícios: </h2>
<br>1 - Ser executado a todo o momento (feedback rápidos)
<br>2 - Qualidade de código (pode validar se a entrada está correta com a saída)
<br>3 - Documentação (Criando teste e cénarios você aprenderá a documentar os passo a passo do método ou regra)
<br><img src="test/img/Screenshot_1.png" width="260" height="250">
