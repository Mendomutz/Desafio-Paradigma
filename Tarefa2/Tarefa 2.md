# Tarefa 2

|                     SQL 1                     |                                    SQL 2                                     |
|:---------------------------------------------:|:----------------------------------------------------------------------------:|
| ``SELECT COUNT(Codigo) as Total FROM Pedido`` | ``SELECT COUNT(Codigo) as Total123 From Pedido WHERE CodigoComprador = 123`` |
|                  Total = 100                  |                                Total123 = 15                                 |

Dado o resultado acima, qual sera o resultado do SQL abaixo?

``SELECT COUNT(Codigo) as TotalFinal FROM Pedido WHERE CodigoComprador <> 123``

Resultado
>85

Como existem 100 Codigos e existe 15 codigos onde o CodigoComprador é 123, entao se pegar todos os
codigos onde o CodigoComprador não é 123, o resultado é 85

<!-- Feito em Markdown 
Caso for abrir no VSC, aperte CTRL+Shift+P e selecione `Markdown: Open Preview`
Necessaria a extensão bierner.markdown-preview-github-styles -->
