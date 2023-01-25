# Formatação de data padrão RFC 3339

O significado da sigla RFC é Request For Comment. O RFC é um documento formal da Internet Engineering Task Force (IETF) e pode ser acessado através do <a href="https://www.rfc-editor.org/rfc/rfc3339.html">link</a>

O padrão DateTime proposto é
2023-01-24T22:28:52Z 

O caractere ‘T’ é usado para separar data e hora, mas no RFC 3339 também pode ser usado apenas um espaço vazio. 

## Fuso horário
A adição do caractere ‘Z’ no final da data serve para referenciar zona e fuso horário. O ‘Z’ significa que o fuso horário é UTC + 0.

## Padrão RFC 3339 para horário de Brasília

Se assumirmos que o DateTime do Brasil é
24/01/2023 19:28:52 
Em padrão RFC 3339 deve ser adicionado +3 horas (fuso horário de Brasília) e o horário correto deve ser:
2023-01-24T22:28:52Z

### <a href="https://github.com/s-s-silva/DateRFC3339/blob/master/DateRFC3339.cs">Implementação</a>
