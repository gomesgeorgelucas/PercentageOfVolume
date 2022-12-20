# PercentageOfVolume

- No mercado financeiro utiliza-se uma estrat�gia chamada Percentage of Volume (POV) para executar opera��es durante o dia, seja de compra ou venda, respeitando um determinado volume.

- Por exemplo, ao configurar uma POV para fazer 10% do mercado na compra de PETR4, � esperado que, quando tivermos 100 execu��es totais no mercado, a estrat�gia seja respons�vel por 10 quantidades desse total de 100 executadas.

- Para que tal fato aconte�a, a estrat�gia deve considerar a sua execu��o para calcular quantas a��es devem enviar. Ou seja, quando o mercado tiver executado 90 ordens, a estrat�gia precisa calcular 10, pois 90 + 10 = 100, e 10/100 = 10%.

- Implemente a fun��o que retorna a quantidade que a estrat�gia deve enviar ao mercado, dada a porcentagem e o total negociado.