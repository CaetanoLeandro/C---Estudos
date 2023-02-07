using bytebank;

ContaCorrente contaDoAndre  = new ContaCorrente();
contaDoAndre.titular = "Andre Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da Conta do André = "+contaDoAndre.saldo);

contaDoAndre.Depositar(100);

//Console.WriteLine("Saldo da Conta do André, pós deposito = " + contaDoAndre.saldo);

//ContaCorrente conta = new ContaCorrente();
Console.WriteLine($"Titular da conta: {contaDoAndre.titular}");
Console.WriteLine($"Número da conta: {contaDoAndre.conta}");
Console.WriteLine($"Agência: {contaDoAndre.numero_agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDoAndre.saldo)}");

Console.ReadKey();