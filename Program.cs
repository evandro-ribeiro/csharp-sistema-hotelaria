using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Console.WriteLine("Digite o número de hóspedes:");
int numeroHospedes = int.Parse(Console.ReadLine());

for (int i = 0; i < numeroHospedes; i++)
{
    hospedes.Add(new Pessoa(nome: $"Hóspede {i}"));
}

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: R${reserva.CalcularValorDiaria():F2}");