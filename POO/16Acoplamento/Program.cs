

using _16Acoplamento;

ComportamentoAndar andar = new();
ComportamentoNadar nadar = new();

var homem = new Homem(andar);
homem.Locomocao();

var mamaco = new Macaco(andar);
mamaco.Locomocao();

var sardinha = new Sardinha(nadar);
sardinha.Locomocao();

Console.ReadKey();
