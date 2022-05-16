// See https://aka.ms/new-console-template for more information
using BancoSistema;

internal class ContaBancaria : Conta
{
    private int numero;
    private double depositoInicial;

    public ContaBancaria(int numero, string? titular)
    {
        this.numero = numero;
        Titular = titular;
    }

    public ContaBancaria(int numero, string? titular, double depositoInicial)
    {
        this.numero = numero;
        Titular = titular;
        this.depositoInicial = depositoInicial;
    }
}